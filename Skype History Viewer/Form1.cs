using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SKYPE4COMLib;

namespace Skype_History_Viewer
{
    public partial class FrmMain : Form
    {
        private Boolean connected = false;
        private Skype skype = new Skype();

        public FrmMain()
        {
            InitializeComponent();
            connected = connectToSkype();
        }

        private void cmdAdd_Click(object sender, EventArgs e)
        {
            if(!connected)
            {
                errorMessage();
            }
            else
            {
                //displays the chat of selected user
                String name = lstUsers.GetItemText(lstUsers.SelectedItem);
                String display = "";

                foreach (Chat oChat in skype.Chats)
                {

                    foreach (ChatMessage oMessage in oChat.Messages)
                    {
                        if(oMessage.Sender.FullName.Equals(name))
                        {
                            if (chTime.Checked) display = oMessage.Timestamp.ToString() + "   ";
                            if (chUser.Checked)
                            {
                                display += oMessage.Sender.FullName + "   ";
                            }
                            
                            display += oMessage.Body;
                            lstChat.Items.Add(display);
                            display = "";
                        }
                        
                    }
                }
            }
        }

        private void errorMessage()
        {
            connected = connectToSkype();
            if(!connected)
            {
                MessageBox.Show("Could not connect to skype, please make sure that skype is running and this plugin is allowed.");
            }
            
        }


        private Boolean connectToSkype()
        {
            try
            {
                //attaches the program to skype
                skype.Attach();

                //adds all users to lstUsers
                if(!connected)
                {
                    foreach (User user in skype.Friends)
                    {
                        lstUsers.Items.Add(user.FullName);
                    }
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void cmdExport_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                errorMessage();
            }
            else
            {
                String name = lstUsers.GetItemText(lstUsers.SelectedItem);
                String path = saveFileDialog("Skype_History_" + name + ".txt");
                if(path != null)
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(path);
                
                    String line = "";
                    foreach (Chat oChat in skype.Chats)
                    {
                        foreach (ChatMessage oMessage in oChat.Messages)
                        {
                            if(oMessage.Sender.FullName.Equals(name))
                            {
                                if (chTime.Checked) line = oMessage.Timestamp.ToString() + "  ";
                                if (chUser.Checked) line += oMessage.Sender.FullName + "   ";
                                line += oMessage.Body;
                                file.WriteLine(line);
                                line = "";
                            }
                        }
                    }
                    file.Close();
                    MessageBox.Show("Save Complete");
                }
            }
        }

        private void cmdExportAll_Click(object sender, EventArgs e)
        {
            if (!connected)
            {
                errorMessage();
            }
            else
            {
                String path = saveFileDialog("SkypeHistory.txt");
                if(path != null) //makes sure that user did not click on cancle on save file dialog
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter(path);
                    String line = "";

                    //exports all skype history to a text file
                    foreach (Chat oChat in skype.Chats)
                    {
                        foreach (ChatMessage oMessage in oChat.Messages)
                        {                    
                            if (chTime.Checked) line = oMessage.Timestamp.ToString() + "  ";
                            if (chUser.Checked) line += oMessage.Sender.FullName + "   ";
                            line += oMessage.Body;
                            file.WriteLine(line);
                            line = "";
                        }
                    }
                    file.Close();
                    MessageBox.Show("Save Complete");
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            lstChat.Items.Clear();
        }
        private String saveFileDialog(String text)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.FileName = text;
            saveFile.Filter = "Text files (*.txt)|*.txt|All files (*.*)|*.*";
            if(saveFile.ShowDialog() == DialogResult.OK)
            {
                return saveFile.FileName;
            }
            return null;
        }
    }
}
