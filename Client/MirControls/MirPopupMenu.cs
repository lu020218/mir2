using System;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;
using Client.MirGraphics;
using System.Collections.Generic;

namespace Client.MirControls
{
    public class MirPopupMenu : MirControl
    {
        private MirButton _MenuBtn;
        private string _MenuName;
        private int _ClickBtnIndex = 0;
        private MirButton[] _Option;
        private List<String> _Items = new List<string>();

        public int ClickBtnIndex
        {
            get
            {
                return _ClickBtnIndex;
            }
            set
            {
                _ClickBtnIndex = value;
            }
        }

        public string MenuName
        {
            get
            {
                return _MenuName;
            }
            set
            {
                _MenuName = value;
                MenuNameChanged();
            }
        }

        public List<String> Items
        {
            get
            {
                return _Items;
            }
            set
            {
                _Items = value;
                ItemsChanged();
            }
        }

        public MirPopupMenu()
        {
            
        }

        public void MenuNameChanged()
        {
            _MenuBtn = new MirButton
            {
                Index = 73,
                Parent = this,
                Visible = true,
                Text = _MenuName,
                Library = Libraries.GameUI,
                Location = new Point(0, 0)
            };
            _MenuBtn.Click += (o, e) =>
            {
                _ClickBtnIndex = 0;
                if (_Option[0] != null && _Option[0].IsDisposed)
                {
                    MouseClick(_Option[0].Visible);
                }
            };
        }

        public void ItemsChanged()
        {
            _Option = new MirButton[_Items.Count];
            for (int i = 0; i < _Items.Count; i++)
            {
                _Option[i] = new MirButton
                {
                    Index = 74,
                    Parent = this,
                    Visible = false,
                    Text = _Items[i],
                    Library = Libraries.GameUI,
                    Location = new Point(0, 0)
                };
                _Option[i].Click += (o, e) =>
                {
                    _ClickBtnIndex = i + 1;
                    MouseClick(false);
                };
            }
        }

        private void MouseClick(bool visible)
        {
            for (int i = 0; i < _Option.Length; i++)
            {
                if (_Option[i] != null && _Option[i].IsDisposed)
                {
                    _Option[i].Visible = visible;
                }
            }
        }

        public override void OnMouseClick(MouseEventArgs e)
        {
            base.OnMouseClick(e);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);

            if (!disposing) return;

            if (_MenuBtn != null && !_MenuBtn.IsDisposed)
            {
                _MenuBtn.Dispose();
            }
            _MenuBtn = null;

            for (int i = 0; i < _Option.Length; i++)
            {
                if (_Option[i] != null && !_Option[i].IsDisposed)
                {
                    _Option[i].Dispose();
                }
                _Option[i] = null;
            }
        }
    }
}
