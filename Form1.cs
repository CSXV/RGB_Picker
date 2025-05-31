using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*┏┓╻┏━╸╻ ╻┏━╸┏━┓   ┏━┓┏━╸╺┳╸╺┳╸╻  ┏━╸*/
/*┃┗┫┣╸ ┃┏┛┣╸ ┣┳┛   ┗━┓┣╸  ┃  ┃ ┃  ┣╸ */
/*╹ ╹┗━╸┗┛ ┗━╸╹┗╸   ┗━┛┗━╸ ╹  ╹ ┗━╸┗━╸*/

namespace WindowsFormsApp1 {
public partial class Form1 : Form {
  public Form1() { InitializeComponent(); }

  private void UpdateTextBoxes() {
    textBox1.Text = trackBar1.Value.ToString();
    textBox2.Text = trackBar2.Value.ToString();
    textBox3.Text = trackBar3.Value.ToString();
  }

  private bool ValidateValue(TextBox textbox) {
    if (Convert.ToInt32(textbox.Text) > 255 ||
        Convert.ToInt32(textbox.Text) < 0) {
      MessageBox.Show("Value Is not valid!\nMust be (>= 0 && <= 255)");
      return false;
    }
    return true;
  }

  private void SetRGB() {
    pictureBox2.BackColor =
        Color.FromArgb(255, trackBar1.Value, trackBar2.Value, trackBar3.Value);

    UpdateTextBoxes();
  }

  private void trackBar_Scroll(object sender, EventArgs e) { SetRGB(); }

  private void pictureBox2_Click(object sender, EventArgs e) {
    MessageBox.Show("R= " + trackBar1.Value.ToString() +
                        "\nG= " + trackBar2.Value.ToString() +
                        "\nB= " + trackBar3.Value.ToString(),
                    "Values", MessageBoxButtons.OK, MessageBoxIcon.Information,
                    MessageBoxDefaultButton.Button1);
  }

  private void textBox1_TextChanged(object sender, EventArgs e) {
    if (!ValidateValue((TextBox)sender)) {
      return;
    } else {
      trackBar1.Value = Convert.ToByte(textBox1.Text);
      SetRGB();
    }
  }

  private void textBox2_TextChanged(object sender, EventArgs e) {
    if (!ValidateValue((TextBox)sender)) {
      return;
    } else {
      trackBar2.Value = Convert.ToByte(textBox2.Text);
      SetRGB();
    }
  }

  private void textBox3_TextChanged(object sender, EventArgs e) {
    if (!ValidateValue((TextBox)sender)) {
      return;
    } else {
      trackBar3.Value = Convert.ToByte(textBox3.Text);
      SetRGB();
    }
  }
}
}
