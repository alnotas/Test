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

      private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
      {
         var senderGrid = (DataGridView)sender;

         if(senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn && e.RowIndex >= 0 && dataGridView1.RowCount > 1)
         {
            if(e.ColumnIndex == 4)
               dataGridView1.Rows.RemoveAt(e.RowIndex);
            if(e.ColumnIndex == 5)
            {
               try
               {
                  int totalRows = dataGridView1.Rows.Count;
                  // get index of the row for the selected cell
                  int rowIndex = dataGridView1.SelectedCells[0].OwningRow.Index;
                  if(rowIndex == 0)
                     return;
                  // get index of the column for the selected cell
                  int colIndex = dataGridView1.SelectedCells[0].OwningColumn.Index;
                  DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                  dataGridView1.Rows.Remove(selectedRow);
                  dataGridView1.Rows.Insert(rowIndex - 1, selectedRow);
                  dataGridView1.ClearSelection();
                  dataGridView1.Rows[rowIndex - 1].Cells[colIndex].Selected = true;
               }
               catch { }
            }
            if(e.ColumnIndex == 6)
            {
               try
               {
                  int totalRows = dataGridView1.Rows.Count;
                  // get index of the row for the selected cell
                  int rowIndex = dataGridView1.SelectedCells[0].OwningRow.Index;
                  if(rowIndex == totalRows - 2)
                     return;
                  // get index of the column for the selected cell
                  int colIndex = dataGridView1.SelectedCells[0].OwningColumn.Index;
                  DataGridViewRow selectedRow = dataGridView1.Rows[rowIndex];
                  dataGridView1.Rows.Remove(selectedRow);
                  dataGridView1.Rows.Insert(rowIndex + 1, selectedRow);
                  dataGridView1.ClearSelection();
                  dataGridView1.Rows[rowIndex + 1].Cells[colIndex].Selected = true;
               }
               catch { }
            }
         }
      }

      private void dataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
      {
         if(e.RowIndex < 0)
            return;
         if(e.ColumnIndex >= 4)
         {
            e.Paint(e.CellBounds, DataGridViewPaintParts.All);

            var w = imageList1.Images[e.ColumnIndex - 4].Width;
            var h = imageList1.Images[e.ColumnIndex - 4].Height;
            var x = e.CellBounds.Left + (e.CellBounds.Width - w) / 2;
            var y = e.CellBounds.Top + (e.CellBounds.Height - h) / 2;

            e.Graphics.DrawImage(imageList1.Images[e.ColumnIndex - 4], new Rectangle(x, y, w, h));
            e.Handled = true;
         }
      }

      private void MainForm_Shown(object sender, EventArgs e)
      {
         DataGridViewRow r1 = new DataGridViewRow();
         r1.CreateCells(dataGridView1);
         r1.Cells[0].Value = true;
         r1.Cells[1].Value = "Price List";
         r1.Cells[2].Value = "Percentage";
         r1.Cells[3].Value = 5.00;
         dataGridView1.Rows.Add(r1);

         DataGridViewRow r2 = new DataGridViewRow();
         r2.CreateCells(dataGridView1);
         r2.Cells[0].Value = true;
         r2.Cells[1].Value = "Promotion";
         r2.Cells[2].Value = "Percentage";
         r2.Cells[3].Value = 10;
         dataGridView1.Rows.Add(r2);

         DataGridViewRow r3 = new DataGridViewRow();
         r3.CreateCells(dataGridView1);
         r3.Cells[0].Value = true;
         r3.Cells[1].Value = "Coupon";
         r3.Cells[2].Value = "Fixed amount";
         r3.Cells[3].Value = 10.00;
         dataGridView1.Rows.Add(r3);

         DataGridViewRow r4 = new DataGridViewRow();
         r4.CreateCells(dataGridView1);
         r4.Cells[0].Value = false;
         r4.Cells[1].Value = "Black Friday Sale";
         r4.Cells[2].Value = "Fixed amount";
         r4.Cells[3].Value = 15.00;
         dataGridView1.Rows.Add(r4);
      }

      private void button1_Click(object sender, EventArgs e)
      {
         clOrderDiscounts TotalDsc = new clOrderDiscounts(Convert.ToDouble(tbTotalAmount.Text));
         foreach(DataGridViewRow curRow in dataGridView1.Rows)
         {
            if(curRow.Cells[0].Value == null)
               continue;
            if(Convert.ToBoolean(Convert.ToInt32(curRow.Cells[0].Value)))
            {
               TotalDsc.Add(new clDiscount((string)curRow.Cells[1].Value,
                                               ((string)curRow.Cells[2].Value == "Fixed amount" ? TdscType.dscFixed : TdscType.dscPercentage),
                                               Convert.ToDouble(curRow.Cells[3].Value)
                                               )
                                            );
            }
         }
         double totalDiscount = TotalDsc.CalcDiscount();
         tbResults.Clear();
         tbResults.AppendText(TotalDsc.visualDiscount);
         tbResults.AppendText("--------------------------\r\n");
         tbResults.AppendText("Total Discounts(" + TotalDsc.Count.ToString() + ") : " + totalDiscount.ToString("0.00 €"));
      }
   }
}
