using System.Collections.ObjectModel;
using UI.Commands;

namespace UI
{
    public class DemoViewModel : BaseViewModel
    {
        private string textBoxContent;
        private ObservableCollection<string> animals;
        public string Label
        {
            get { return "Add an animal"; }
        }

        public string TextBoxContent
        {
            get { return textBoxContent; }
            set
            {
                textBoxContent = value;
                OnPropertyChanged(nameof(TextBoxContent));
            }
        }

        public ObservableCollection<string> Animals
        {
            get { return animals; }
            set { animals = value; }
        }

        public DelegateCommand AddAnimalCommand { get; set; }

        public DemoViewModel()
        {
            Animals = new ObservableCollection<string>();
            AddAnimalCommand = new DelegateCommand(AddAnimal);
        }

        public void AddAnimal()
        {
            if (!string.IsNullOrEmpty(TextBoxContent))
            {
                Animals.Add(TextBoxContent);
                TextBoxContent = string.Empty;
            }
        }
    }
}
