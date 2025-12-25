using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POJAR_GUI2
{
    public partial class ResultsForm : Form
    {
        private string scryptPath = "E:\\Dipl\\POJAR_REGR_UI\\POJAR_GUI2\\predict_area.py"; //MODEL SCRYPT PATH
        private string pythonPath = "C:\\Users\\kamel\\AppData\\Local\\Programs\\Python\\Python313\\python.exe";

        public ResultsForm()
        {
            InitializeComponent();
            par5_box.SelectedIndex = 0;
            par6_box.SelectedIndex = 0;
            par7_box.SelectedIndex = 0;
            par8_box.SelectedIndex = 0;
        }

        private void button_Predict_Click(object sender, EventArgs e)
        {
            button_Recognize.Visible = false;
            lbl_wait.Visible = true;
            lbl_wait.Refresh();
            float[] args = new float[] { (float)par1_box.Value, (float)par2_box.Value, (float)par3_box.Value, (float)par4_box.Value, par5_box.SelectedIndex, par6_box.SelectedIndex,
                par7_box.SelectedIndex, par8_box.SelectedIndex};
            string argsString = string.Join(",", args);

            var proc = new Process
            {
                StartInfo = new ProcessStartInfo
                {
                    FileName = pythonPath,
                    Arguments = $"\"{scryptPath}\" \"{argsString}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                    RedirectStandardError = true,
                    StandardOutputEncoding = Encoding.UTF8
                }
            };

            try
            {
                proc.Start();
                string output = proc.StandardOutput.ReadToEnd();
                string errors = proc.StandardError.ReadToEnd();
                proc.WaitForExit();

                // Если были ошибки Python
                if (!string.IsNullOrEmpty(errors))
                {
                    MessageBox.Show($"Python error: {errors}", "Error",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string[] lines = output.Split(new[] { '\r', '\n' },
                    StringSplitOptions.RemoveEmptyEntries);

                string resultLine = lines.FirstOrDefault(line =>
                    line.Contains("Prediction Result:"));

                if (resultLine != null)
                {
                    string[] parts = resultLine.Split(':');
                    if (parts.Length > 1)
                    {
                        string result = parts[1].Trim();
                        //MessageBox.Show($"Результат предсказания: {result}", "Результат",
                        // MessageBoxButtons.OK, MessageBoxIcon.Information);
                        result_box.Text = result;
                    }
                }
                else
                {
                    MessageBox.Show("Не удалось найти результат в выводе", "Ошибка",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка выполнения: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            button_Recognize.Visible = true;
            lbl_wait.Visible = false;
        }

        //private void button_Predict_Click(object sender, EventArgs e)
        //{
        //    button_Recognize.Visible = false;

        //    float[] args = new float[] {1, 2, 3, 4, 5, 6, 7, 8, 9};
        //    string argsString = string.Join(",", args);
        //    var proc = new Process
        //    {
        //        StartInfo = new ProcessStartInfo
        //        {
        //            FileName = pythonPath,
        //            Arguments = string.Format("{0} {1}", scryptPath, argsString),
        //            UseShellExecute = false,
        //            RedirectStandardOutput = true,
        //            CreateNoWindow = true
        //        }
        //    };
        //    proc.Start();
        //    string output = proc.StandardOutput.ReadToEnd();
        //    proc.WaitForExit();
        //    string line = "1";

        //    string[] lines = output.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
        //    string resultLine = lines.FirstOrDefault(line => line.Contains("Prediction Result:"));

        //    if (resultLine != null)
        //    {

        //        string[] parts = resultLine.Split(':');
        //        if (parts.Length > 1)
        //        {
        //            string result = parts[1].Trim();
        //            MessageBox.Show($"Результат предсказания: {result}", "Результат",
        //                      MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            result_box.Text = result;
        //        }
        //    }
        //    else
        //    {
        //        //result_box.Text = "Не удалось найти результат в выводе скрипта";
        //    }

        ////string result = line_list[0] + " " + line_list[1] + "\n" + line_list[2] + " " + line_list[3];

        //    //richTextBox_Result.Text = result;
        //    //textBox1.Text = result;
        //    /*
        //    if (float.Parse(result, CultureInfo.InvariantCulture.NumberFormat) >= 0.5)
        //    {
        //        richTextBox_Result.Text = "Пожар есть!";
        //    }
        //    else
        //    {
        //        richTextBox_Result.Text = "Пожара нет.";
        //    }
        //    richTextBox_Result.Text += "\nВероятность пожара: " + (float.Parse(result, CultureInfo.InvariantCulture.NumberFormat) * 100).ToString("F2") + "%";
        //    */
        //    //richTextBox_Result.Update();
        //    //richTextBox_Result.Text = result;
        //}

        private void button_back_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void par2_box_TextChanged(object sender, EventArgs e)
        {
            if (par2_box.Text == "")
            {
                button_Recognize.Enabled = false;
            }
        }


    }
}
