using System;

namespace Version_2_C
{
    [Serializable()]
    public class clsPainting : clsWork
    {
        public delegate void LoadPaintingFormDelegate(clsPainting prPainting);
        public static LoadPaintingFormDelegate LoadPaintingForm;

        private float _Width;
        private float _Height;
        private string _Type;


        // New EditDetails calls delegate
        public override void EditDetails() {
            LoadPaintingForm(this);
        }

        /* OLD 
        public override void EditDetails()
        {
            if (_PaintDialog == null)
                _PaintDialog = frmPainting.Instance;
            _PaintDialog.SetDetails(this);
        }
        */

        public Single Width
        {
            get { return _Width; }
            set { _Width = value; }
        }

        public Single Height
        {
            get { return _Height; }
            set { _Height = value; }
        }

        public string Type
        {
            get { return _Type; }
            set { _Type = value; }
        }
    }
}
