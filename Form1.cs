using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;

namespace CP_Preprocessing
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            QueryData query = new QueryData();
            query.executeStoredProcedure("RemoveTable");
            int status = query.executeStoredProcedure("CP_Preprocessing");
            if (status == 0) this.toolStripStatusLabel1.Text = "已成功執行預存程序";
            else this.toolStripStatusLabel1.Text = "執行預存程序失敗";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.toolStripStatusLabel1.Text = "已就緒";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            CPValueOperation operation = new CPValueOperation();

            string result = JsonConvert.SerializeObject(operation.GetRootObject());
            SaveFile(result);
        }

        private void SaveFile(string resultJSON)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "JSON File|*.json";
            saveFile.Title = "Save JSON File";
            saveFile.ShowDialog();
            if (!saveFile.FileName.Equals(string.Empty))
            {
                File.WriteAllText(saveFile.FileName, resultJSON, Encoding.UTF8);
            }
        }
    }
}
