using System.ComponentModel;

namespace FusionVoiceIndicator
{
    public class SteamVoiceActivityEvent : INotifyPropertyChanged
    {
        private bool hasVoiceData;

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
                handler(this, e);
        }

        protected void OnPropertyChanged([System.Runtime.CompilerServices.CallerMemberName] string propertyName = "")
        {
            OnPropertyChanged(new PropertyChangedEventArgs(propertyName));
        }
        public bool HasVoiceData
        {
            get { return hasVoiceData; }
            set
            {
                if (value != hasVoiceData)
                {
                    hasVoiceData = value;
                    OnPropertyChanged();
                }
            }
        }

    }

}