using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OnDisplayKeyBoard
{
    public partial class Keybord : Form
    {
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        public Keybord()
        {
            InitializeComponent();
        }

        private void Qkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{Q}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            } 
            else
            {
                SendKeys.Send("{q}");
            }
        }

        private void Wkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{W}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{w}");
            }
        }

        private void Ekey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{E}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{e}");
            }
        }

        private void Rkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{R}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{r}");
            }
        }

        private void Tkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{T}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{t}");
            }
        }

        private void Ykey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{Y}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{y}");
            }
        }

        private void Ukey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{U}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{u}");
            }
        }

        private void Ikey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{I}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{i}");
            }
        }

        private void Okey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{O}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{o}");
            }
        }

        private void Pkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{P}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{p}");
            }
        }

        private void LeftBarckkey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{{}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{[}");
            }
        }

        private void RightBarckkey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{}}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{]}");
            }
        }

        private void VerticalBarkey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{|}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{\\}");
            }
        }

        private void Akey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{A}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{a}");
            }
        }

        private void Skey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{S}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{s}");
            }
        }

        private void Dkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{D}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{d}");
            }
        }

        private void Fkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{F}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{f}");
            }
        }

        private void Gkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{G}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{g}");
            }
        }

        private void Hkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{H}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{h}");
            }
        }

        private void Jkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{J}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{j}");
            }
        }

        private void Kkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{K}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{k}");
            }
        }

        private void Lkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{L}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{l}");
            }
        }

        private void Colomnskey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{;}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{:}");
            }
        }

        private void Cotashenkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{'}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{\"}");
            }
        }

        private void Zkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{Z}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{z}");
            }
        }

        private void Xkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{X}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{x}");
            }
        }

        private void Ckey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{C}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{c}");
            }
        }

        private void Vkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{V}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{v}");
            }
        }

        private void Bkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{B}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{b}");
            }
        }

        private void Nkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{N}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{n}");
            }
        }

        private void Mkey_Click(object sender, EventArgs e)
        {
            if (CapsLock.Checked || LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{M}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{m}");
            }
        }

        private void SmallerCarlykey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{<}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{,}");
            }
        }

        private void BiggerCarlykey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{>}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{.}");
            }
        }

        private void Qustionkey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{?}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{/}");
            }
        }

        private void Spacekey_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ }");
            LeftShiftkey.Checked = false;
            RightShiftkey.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{~}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{`}");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{!}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{1}");
            }
        }

        private void Twokey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{@}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{2}");
            }
        }

        private void Threekey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{#}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{3}");
            }
        }

        private void Fourkey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{$}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{4}");
            }
        }

        private void Fivekey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{%}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{5}");
            }
        }

        private void Sixkey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{^}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{6}");
            }
        }

        private void Sevenkey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{&}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{7}");
            }
        }

        private void Eightkey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{*}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{8}");
            }
        }

        private void Ninekey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {   
                SendKeys.Send("{(}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{9}");
            }
        }

        private void Zerokey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{)}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{0}");
            }
        }

        private void Minkey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{_}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{-}");
            }
        }

        private void PlusEqualkey_Click(object sender, EventArgs e)
        {
            if (LeftShiftkey.Checked || RightShiftkey.Checked)
            {
                SendKeys.Send("{+}");
                LeftShiftkey.Checked = false;
                RightShiftkey.Checked = false;
            }
            else
            {
                SendKeys.Send("{=}");
            }
        }

        private void Zero2key_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{0}");

            }
            else
            {
                SendKeys.Send("{}");
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{.}");

            }
            else
            {
                SendKeys.Send("{}");
            }
        }

        private void One2key_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{1}");
                
            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Two2key_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{2}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Three2key_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{3}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Four2key_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{4}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Five2key_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{5}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Six2key_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{6}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Seven2key_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{7}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Eight2key_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{8}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Nine2key_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{9}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Dividkey_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{/}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Asteriskkey_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{*}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Minuskey_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{-}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Pluskey_Click(object sender, EventArgs e)
        {
            if (NumLKkey.Checked)
            {
                SendKeys.Send("{+}");

            }
            else
            {
                SendKeys.Send("");
            }
        }

        private void Enterkey_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void Enter2key_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void ESCkey_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ESC}");
        }

        private void Windowkey_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }

        private void Win2key_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{HOME}");
        }
    }
}