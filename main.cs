using System;
using System.Windows.Forms;
using wclCommon;
using wclBluetooth;
using System.IO.Ports;
using System.Diagnostics;
using System.IO;

namespace BluetoothLEnergy
{
    public partial class fmMain : Form
    {
        private wclBluetoothManager Manager;
        private wclGattClient Client;
        private SerialPort serial = new SerialPort();
        private wclGattCharacteristic[] FCharacteristics;
        private wclGattService[] FServices;
        private string data;
        public fmMain()
        {
            InitializeComponent();
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            Manager = new wclBluetoothManager();
            Client = new wclGattClient();

            
            Manager.OnDeviceFound += new wclBluetoothDeviceEvent(Manager_OnDeviceFound);
            Manager.OnDiscoveringCompleted += new wclBluetoothResultEvent(Manager_OnDiscoveringCompleted);
            Manager.OnDiscoveringStarted += new wclBluetoothEvent(Manager_OnDiscoveringStarted);

            
            Client.OnConnect += new wclCommunication.wclClientConnectionConnectEvent(Client_OnConnect);
            Client.OnDisconnect += new wclCommunication.wclClientConnectionDisconnectEvent(Client_OnDisconnect);

            string[] ports = SerialPort.GetPortNames();  //Ba�l� olan seri portlar� diziye ekler
            foreach (string port in ports)
                cbSerialName.Items.Add(port);

            cbBaund.Items.Add("4800");
            cbBaund.Items.Add("9600");
            cbBaund.Items.Add("14400");
            cbBaund.Items.Add("19200");
            cbBaund.Items.Add("38400");
            cbBaund.Items.Add("56000");
            cbBaund.Items.Add("57600");
            cbBaund.Items.Add("115200");

            cbData.Items.Add("7");
            cbData.Items.Add("8");

            cbParity.Items.Add("Hi�biri");
            cbParity.Items.Add("Odd");
            cbParity.Items.Add("Even ");
            cbParity.Items.Add("Mark");
            cbParity.Items.Add("Space");

            cbHandshake.Items.Add("Kapal�");
            cbHandshake.Items.Add("RTC/CTS");
            cbHandshake.Items.Add("Xon/Xoff");

            serial.DataReceived += new SerialDataReceivedEventHandler(serial_DataReceived);

            // In real application you should always analize the result code.
            // In this demo we assume that all is always OK.
            Manager.Open();
            
            //.SelectedIndex = 0;
            //cbProtection.SelectedIndex = 0;

            Cleanup();
        }

        private void serial_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            data = serial.ReadLine();                      //Veriyi al
            this.Invoke(new EventHandler(displayData_event));
        }
        private void displayData_event(object sender, EventArgs e)
        {
            if (btSaveCSV.Enabled)
            {
                string[] SplitedData = data.Split(',');
                File.AppendAllText(@"C:\Users\oguzn\OneDrive\Masa�st�\MyLog.csv", string.Format("\"{0}\", {1} , {2}\n",
                    DateTime.Now.ToString("mm:ss.fff"), SplitedData[0],SplitedData[1]));
            }
            else { 
            SerialScreen.Text += data + "\n"; //Gelen veriyi textBox i�ine
            } 
        }
        void Client_OnDisconnect(object Sender, int Reason)
        {
            // Connection property is valid here.
            TraceEvent(((wclGattClient)Sender).Address, "Disconnected", "Reason", "0x" + Reason.ToString("X8"));
            
            Cleanup();
        }

        void Client_OnConnect(object Sender, int Error)
        {
            // Connection property is valid here.
            TraceEvent(((wclGattClient)Sender).Address, "Connected", "Error", "0x" + Error.ToString("X8"));
        }

        void Manager_OnDiscoveringStarted(object Sender, wclBluetoothRadio Radio)
        {
            lvDevices.Items.Clear();
            TraceEvent(0, "Discovering started", "", "");
        }

        void Manager_OnDiscoveringCompleted(object Sender, wclBluetoothRadio Radio, int Error)
        {
            if (lvDevices.Items.Count == 0)
                MessageBox.Show("BLE s�r�c�s� bulunamad�", "BLE S�r�c�s� Arama", MessageBoxButtons.OK, MessageBoxIcon.Information);
            else
                // S�r�c� buldu�unda g�nceller
                for (Int32 i = 0; i < lvDevices.Items.Count; i++)
                {
                    ListViewItem Item = lvDevices.Items[i];

                    Int64 Address = Convert.ToInt64(Item.Text, 16);
                    String DevName;
                    Int32 Res = Radio.GetRemoteName(Address, out DevName);
                    if (Res != wclErrors.WCL_E_SUCCESS)
                        Item.SubItems[1].Text = "Error: 0x" + Res.ToString("X8");
                    else
                        Item.SubItems[1].Text = DevName;
                }

            TraceEvent(0, "Discovering completed", "", "");
        }

        void Manager_OnDeviceFound(object Sender, wclBluetoothRadio Radio, long Address)
        {
            wclBluetoothDeviceType DevType = wclBluetoothDeviceType.dtMixed;
            Int32 Res = Radio.GetRemoteDeviceType(Address, out DevType);

            ListViewItem Item = lvDevices.Items.Add(Address.ToString("X12"));
            Item.SubItems.Add(""); // We can not read a device's name here.
            Item.Tag = Radio; // To use it later.
            if (Res != wclErrors.WCL_E_SUCCESS)
                Item.SubItems.Add("Error: 0x" + Res.ToString("X8"));
            else
                switch (DevType)
                {
                    case wclBluetoothDeviceType.dtClassic:
                        Item.SubItems.Add("Classic");
                        break;
                    case wclBluetoothDeviceType.dtBle:
                        Item.SubItems.Add("BLE");
                        break;
                    case wclBluetoothDeviceType.dtMixed:
                        Item.SubItems.Add("Mixed");
                        break;
                    default:
                        Item.SubItems.Add("Unknown");
                        break;
                }

            TraceEvent(Address, "Device found", "", "");
        }

        private void fmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            Client.Disconnect();
            Client = null;

            Manager.Close();
            Manager = null;

            Cleanup();
        }

        private wclBluetoothRadio GetRadio()
        {
           
            for (Int32 i = 0; i < Manager.Count; i++)
                if (Manager[i].Available)
                    // Return first non MS.
                    return Manager[i];

            MessageBox.Show("Bluetooth cihaz� bulunamad�", "Hata", MessageBoxButtons.OK,
                MessageBoxIcon.Error);

            return null;
        }

        private void btDiscover_Click(object sender, EventArgs e)
        {
            wclBluetoothRadio Radio = GetRadio();
            if (Radio != null)
            {
                Int32 Res = Radio.Discover(10, wclBluetoothDiscoverKind.dkBle);
                if (Res != wclErrors.WCL_E_SUCCESS)
                    MessageBox.Show("Tarama ba�lat�rken bir sorunla kar��la��ld�: 0x" + Res.ToString("X8"),
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btClear_Click(object sender, EventArgs e)
        {
            lvEvents.Items.Clear();
            SerialScreen.Clear();
            btValuePanel.Clear();
        }

        private void TraceEvent(Int64 Address, String Event, String Param, String Value)
        {
            String s = "";
            if (Address != 0)
                s = Address.ToString("X12");
            ListViewItem Item = lvEvents.Items.Add(s);
            Item.SubItems.Add(Event);
            Item.SubItems.Add(Param);
            Item.SubItems.Add(Value);
        }

        private void btConnect_Click(object sender, EventArgs e)
        {
            if (lvDevices.SelectedItems.Count == 0)
                MessageBox.Show("S�r�c� se�in", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                ListViewItem Item = lvDevices.SelectedItems[0];
                Client.Address = Convert.ToInt64(Item.Text, 16);
                Client.ConnectOnRead = false;
                Int32 Res = Client.Connect((wclBluetoothRadio)Item.Tag);
                if (Res != wclErrors.WCL_E_SUCCESS)
                    MessageBox.Show("Hata: 0x" + Res.ToString("X8"), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btDisconnect_Click(object sender, EventArgs e)
        {
            Int32 Res = Client.Disconnect();
            if (Res != wclErrors.WCL_E_SUCCESS)
                MessageBox.Show("Hata: 0x" + Res.ToString("X8"), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btGetServices_Click(object sender, EventArgs e)
        {
            lvServices.Items.Clear();
            FServices = null;
            
            Int32 Res = Client.ReadServices(0, out FServices);
            if (Res != wclErrors.WCL_E_SUCCESS)
            {
                MessageBox.Show("Hata: 0x" + Res.ToString("X8"), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (FServices == null)
                return;
            
            foreach(wclGattService Service in FServices)
            {
                String s;
                if (Service.Uuid.IsShortUuid)
                    s = Service.Uuid.ShortUuid.ToString("X4");
                else
                    s = Service.Uuid.LongUuid.ToString();
                ListViewItem Item = lvServices.Items.Add(s);
                Item.SubItems.Add(Service.Uuid.IsShortUuid.ToString());
                
            }
        }

        private void btGetCharacteristics_Click(object sender, EventArgs e)
        {
            FCharacteristics = null;
            lvCharacteristics.Items.Clear();
            
            if (lvServices.SelectedItems.Count == 0)
            {
                MessageBox.Show("Hizmet se�in", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            wclGattService Service = FServices[lvServices.SelectedItems[0].Index];
            Int32 Res = Client.ReadCharacteristics(Service, 0, out FCharacteristics);
            if (Res != wclErrors.WCL_E_SUCCESS)
            {
                MessageBox.Show("Hata: 0x" + Res.ToString("X8"), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            if (FCharacteristics == null)
                return;
            
            foreach(wclGattCharacteristic Character in FCharacteristics)
            {
                String s;
                if (Character.Uuid.IsShortUuid)
                    s = Character.Uuid.ShortUuid.ToString("X4");
                else
                    s = Character.Uuid.LongUuid.ToString();
                ListViewItem Item = lvCharacteristics.Items.Add(s);
                
                Item.SubItems.Add(Character.Uuid.IsShortUuid.ToString());
                
            }
        }
        
        private string getDataPackage()
        {
            if (lvCharacteristics.SelectedItems.Count == 0)
            {
                MessageBox.Show("Karakteristik se�in", "Uyar�", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "";
            }

            wclGattCharacteristic Characteristic = FCharacteristics[lvCharacteristics.SelectedItems[0].Index];
            Byte[] Value;
            Int32 Res = Client.ReadCharacteristicValue(Characteristic, 0, out Value, 0);
            if (Res != wclErrors.WCL_E_SUCCESS)
            {
                MessageBox.Show("Hata: 0x" + Res.ToString("X8"), "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return "";
            }

            if (Value == null)
                return "";

            try
            {
                if (Value.Length == 0)
                    MessageBox.Show("Bo� de�er", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                {
                    String Str = "";
                    String temp = "";

                    for (Int32 i = 0; i < Value.Length; i++)
                    {
                        if (i % 2 != 0)
                        {
                            temp = temp + Value[i].ToString("X2");
                            if ((i + 1) == Value.Length)
                            {
                                Str = Str + temp;
                            }
                            else
                            {
                                Str = Str + temp + " ";
                            }
                            temp = "";
                        }
                        else { temp = temp + Value[i].ToString("X2") + " "; }
                    }

                    String[] hexValue = Str.Split(' ');
                    Str = "";
                    for (int i = 0; i < hexValue.Length; i++)
                    {

                        int value = Convert.ToInt32(hexValue[i], 16);
                        String stringValue = Char.ConvertFromUtf32(value);
                        Str = Str + stringValue;

                    }
                    return Str;
                }
            }
            finally
            {
                Value = null;
                
            }
            return "";
        }
        private void btGetCharValue_Click(object sender, EventArgs e)
        {

            if (btreadRegular.Checked == true)
            {
                string str = "";
                while (true)
                {
                    str+= getDataPackage();
                    str += "\n";
                    btValuePanel.Text = str;
                }
                

            }
            else { string package = getDataPackage();
                String[] parsed_data = package.Split(';');
                string Str = "";
                Str += parsed_data[0] + " ";
                if (yaktsevbut.Checked)
                {
                    Str += parsed_data[1];
                }
                else if (mnzlbut.Checked)
                {
                    Str += parsed_data[2];
                }
                else if (orttktbut.Checked)
                {
                    Str += parsed_data[3];
                }
                else if (anlyktbut.Checked)
                {
                    Str += parsed_data[4];
                }
                else if (anlh�zbut.Checked)
                {
                    Str += parsed_data[5];
                }
                else if (rpmbut.Checked)
                {
                    Str += parsed_data[6];
                }
                else if (alnyolbut.Checked)
                {
                    Str += parsed_data[7];
                }
                else if (lpgbnzbut.Checked)
                {
                    Str += parsed_data[8];
                }

                Str += parsed_data[parsed_data.Length - 2];
                btValuePanel.Text = Str;

            }
            

        }
       

        private void Cleanup()
        {
            FCharacteristics = null;
            FServices = null;

            lvServices.Items.Clear();
            lvCharacteristics.Items.Clear();
            
        }

        
        Int32 selected_Baund()
        {
            switch (cbBaund.SelectedIndex)
            {
                case 1:
                    return 9600;
                case 2:
                    return 14400;
                case 3:
                    return 19200;
                case 4:
                    return 38400;
                case 5:
                    return 56000;
                case 6:
                    return 57600;
                case 7:
                    return 115200;
                default:
                    return 4800;
            }

        }
        Int32 selectedDatabit()
        {
            if (cbData.SelectedIndex == 0)
                return 7;
            else
                return 8;
        }
        Parity selectedParity()
        {
            switch (cbParity.SelectedIndex)
            {
                case 0:
                    return Parity.None;
                case 1:
                    return Parity.Odd;
                case 2:
                    return Parity.Even;
                case 3:
                    return Parity.Mark;
                case 4:
                    return Parity.Space;
                default:
                    return Parity.None;
            }
        }
        Handshake selectedHandshake()
        {
            switch (cbHandshake.SelectedIndex)
            {
                case 0:
                    return Handshake.None;
                case 1:
                    return Handshake.RequestToSend;
                case 2:
                    return Handshake.XOnXOff;
                default:
                    return Handshake.None;
            }
        }
        
        private void btOpen_Click(object sender, EventArgs e)
        {
            
            try { 
            serial.PortName = cbSerialName.Text;
            serial.BaudRate = selected_Baund();
            serial.DataBits = selectedDatabit();
            serial.Parity = selectedParity();
            serial.Handshake = selectedHandshake();
                
            
            serial.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Hata");    
            }


        }

        private void btCloseSerial_Click(object sender, EventArgs e)
        {
            serial.Close();
        }
    }
}