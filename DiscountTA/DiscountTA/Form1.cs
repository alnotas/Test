using System;
using System.Drawing;
using System.Windows.Forms;

namespace DiscountTA
{
   public partial class MainForm : Form
   {
      public MainForm()
      {
         InitializeComponent();
      }

      private void tbTotalAmount_Leave(object sender, EventArgs e)
      {
         Double value;
         if(Double.TryParse(((TextBox)sender).Text, out value))
            ((TextBox)sender).Text = String.Format(System.Globalization.CultureInfo.CurrentCulture, "{0:C2}", value);
         else
            ((TextBox)sender).Text = String.Empty;
      }

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {

      }

      private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
      {
         if(e.RowIndex < 0)
            return;
         if(e.ColumnIndex >= 4)
         {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            var w = imageList1.Images[e.ColumnIndex-4].Width;
            var h = imageList1.Images[e.ColumnIndex-4].Height;
            var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            e.Graphics.DrawImage(imageList1.Images[e.ColumnIndex-4], new Rectangle(x, y, w, h));
            e.Handled = true;
         }
      }
   }
}
