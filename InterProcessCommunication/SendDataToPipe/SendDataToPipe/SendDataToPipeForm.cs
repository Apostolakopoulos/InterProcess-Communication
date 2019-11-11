using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SendDataToPipe
{
    public partial class SendDataToPipeForm : Form
    {
        // the name of the pipe
        private string _pipeName = "ConnectionNamedPipe";

        public SendDataToPipeForm()
        {
            InitializeComponent();
        }

        public void SendToPipe(string SendStr, string PipeName, int TimeOut = 1000)
        {
            try
            {
                NamedPipeClientStream pipeStream = new NamedPipeClientStream(".", PipeName, PipeDirection.Out, PipeOptions.Asynchronous);

                // The connect function will indefinitely wait for the pipe to become available
                // If that is not acceptable specify a maximum waiting time (in ms)
                pipeStream.Connect(TimeOut);

                byte[] _buffer = Encoding.UTF8.GetBytes(SendStr);
                pipeStream.BeginWrite(_buffer, 0, _buffer.Length, AsyncSend, pipeStream);
            }
            catch (TimeoutException oEX)
            {
                throw oEX;
            }
        }

        private void AsyncSend(IAsyncResult iar)
        {
            try
            {
                // Get the pipe
                NamedPipeClientStream pipeStream = (NamedPipeClientStream)iar.AsyncState;

                // End the write
                pipeStream.EndWrite(iar);
                pipeStream.Flush();
                pipeStream.Close();
                pipeStream.Dispose();
            }
            catch (Exception oEX)
            {
                throw oEX;
            }
        }

        private void ButtonSendData_Click(object sender, EventArgs e)
        {
            try
            {
                SendToPipe(TextBoxSendData.Text, _pipeName, 1000);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
