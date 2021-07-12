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
        private int _BtnCount = 0;
        private MirButton[] _Option;
        private List<String> _Items = new List<string>();

        public string MenuName
        {
            get
            {
                return _MenuName;
            }
            set
            {
                _MenuName = value;
            }
        }

        public int ButtonCount
        {
            get
            {
                return _BtnCount;
            }
            set
            {
                _BtnCount = value;
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
            }
        }

        public MirPopupMenu()
        {
            _MenuBtn = new MirButton
            {
                Index = 0,
                HoverIndex = 0,
                PressedIndex = 0,
                Parent = this,
                Visible = true,
                Text = _MenuName,
                Library = Libraries.GameUI,
                Location = new Point(0,0)
            };

            for (int i = 0; i < _BtnCount; i++)
            {
                _Option[i] = new MirButton
                {
                    Index = 0,
                    HoverIndex = 0,
                    PressedIndex = 0,
                    Parent = this,
                    Visible = false,
                    Text = _Items[i],
                    Library = Libraries.GameUI,
                    Location = new Point(0,0)
                };
            }
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
