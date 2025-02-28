using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class CustomCheckBox : CheckBox
{
    public int BaseCheckSize { get; set; } = 10;

    // Propiedad para definir el color de la casilla cuando está marcada.
    public Color CheckedColor { get; set; } = Color.Green;

    protected override void OnPaint(PaintEventArgs e)
    {
        // Limpiar el fondo con el color de fondo del control.
        e.Graphics.Clear(this.BackColor);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        // Calcula el tamaño de la casilla (el doble del tamaño base).
        int checkSize = BaseCheckSize * 2;

        // Define el rectángulo donde se dibujará la casilla, centrado verticalmente.
        Rectangle checkBoxRect = new Rectangle(0, (this.Height - checkSize) / 2, checkSize, checkSize);

        // Dibuja el borde de la casilla.
        using (Pen pen = new Pen(Color.Black, 2))
        {
            e.Graphics.DrawRectangle(pen, checkBoxRect);
        }

        // Si la casilla está marcada, la rellena con el color seleccionado.
        if (this.Checked)
        {
            using (SolidBrush brush = new SolidBrush(CheckedColor))
            {
                e.Graphics.FillRectangle(brush, checkBoxRect);
            }
        }

        // Dibuja el texto del CheckBox, a la derecha de la casilla.
        int textX = checkBoxRect.Right + 5;
        int textY = (this.Height - this.Font.Height) / 2;
        TextRenderer.DrawText(e.Graphics, this.Text, this.Font, new Point(textX, textY), this.ForeColor);
    }
}
