using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDD.UI
{
    public class Form1ViewModel : INotifyPropertyChanged
    {
        //private System.Windows.Forms.Button CalculationButton;

        private IDB _db = new DB();
        private string _aTextBoxText = string.Empty;

        public Form1ViewModel(IDB db)
        {
            _db = db;
        }

        public string ATextBoxText
        {
            get { return _aTextBoxText; }
            set
            {
                if(_aTextBoxText== value)
                {
                    return;
                }
                _aTextBoxText = value;
                OnPropertyChanged("ATextBoxText");
            }
        }

        private string _bTextBoxText = string.Empty;
        public string BTextBoxText
        {
            get { return _bTextBoxText; }
            set
            {
                if (_bTextBoxText == value)
                {
                    return;
                }
                _bTextBoxText = value;
                OnPropertyChanged("BTextBoxText");
            }
        }

        private string _resultLabelText = string.Empty;
        public string ResultLabelText
        {
            get { return _resultLabelText; }
            set
            {
                if (_resultLabelText == value)
                {
                    return;
                }
                _resultLabelText = value;
                OnPropertyChanged("ResultLabelText");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }

        public void CalculationAction()
        {
            int a = Convert.ToInt32(ATextBoxText);
            int b = Convert.ToInt32(BTextBoxText);

            var dbValue = _db.GetDBValue();
            ResultLabelText = ( Calculation.Sum(a, b) + dbValue).ToString();
        }

    }
}
