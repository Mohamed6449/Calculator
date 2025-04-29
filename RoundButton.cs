using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator3
{
    public class RoundButton : Button
    {
        public RoundButton()
        {
            // اختياري: إزالة البوردر الافتراضي
            this.FlatStyle = FlatStyle.Flat;
            this.FlatAppearance.BorderSize = 0;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            // ضبط التجسيم الناعم
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            // إنشاء المسار الدائري
            using (var path = new GraphicsPath())
            {
                path.AddEllipse(0, 0, ClientSize.Width, ClientSize.Height);
                this.Region = new Region(path);
            }

            // تعبئة الخلفية
            using (var brush = new SolidBrush(this.BackColor))
                pevent.Graphics.FillEllipse(brush, 0, 0, ClientSize.Width, ClientSize.Height);

            // رسم النص والباقي
            base.OnPaint(pevent);
        }
    }
}
