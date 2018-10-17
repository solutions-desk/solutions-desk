using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace solutions_desk
{
    public class PlaceHolderTextBox : TextBox
    {

        bool isPlaceHolder = true;
        string _placeHolderText;
        //public string[] _type = new string[2] { "Texto", "Senha" };

        private bool _isSenha;

        public bool IsSenha
        {
            get { return _isSenha; }
            set { _isSenha = value; }
        }

        public string PlaceHolderText
        {
            get { return _placeHolderText; }
            set
            {
                _placeHolderText = value;
                setPlaceholder();
            }
        }

        public new string Text
        {
            get => isPlaceHolder ? string.Empty : base.Text;
            set => base.Text = value;
        }

        //when the control loses focus, the placeholder is shown
        private void setPlaceholder()
        {
            if (string.IsNullOrEmpty(base.Text))
            {
                base.Text = PlaceHolderText;
                this.ForeColor = Color.Gray;
                this.Font = new Font(this.Font, FontStyle.Regular);
                isPlaceHolder = true;
            }
        }

        //when the control is focused, the placeholder is removed
        private void removePlaceHolder()
        {

            if (isPlaceHolder)
            {
                base.Text = "";
                this.ForeColor = System.Drawing.SystemColors.WindowText;
                this.Font = new Font(this.Font, FontStyle.Regular);

                isPlaceHolder = false;
            }
        }
        public PlaceHolderTextBox() : base()
        {

            
            GotFocus += removePlaceHolder;
            LostFocus += setPlaceholder;
            this.BackColor = ColorTranslator.FromHtml("#fafbfc");
            this.Font = new Font("Microsoft Sans Serif", 12.5f);
        }

        private void setPlaceholder(object sender, EventArgs e)
        {
            setPlaceholder();
        }

        private void removePlaceHolder(object sender, EventArgs e)
        {
            removePlaceHolder();
        }

        

    }
}
