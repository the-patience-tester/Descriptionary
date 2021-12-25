using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using Descriptionary.Annotations;
using Descriptionary.GameData;

namespace Descriptionary.ViewModels
{
    public class LetterAssociation : INotifyPropertyChanged
    {
        public LetterAssociation()
        {
            var gd = new GameData.LetterAsociation();
            GameLetter = gd.GetGameLetter();
            GameWords =  gd.GetGameWords();
        }
        
        public string GameLetter { get; set; }
        public LetterAssociationWords GameWords { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(
            [CallerMemberName]
            string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
