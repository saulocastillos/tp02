using System;
using tp02.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace tp02.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AlunoViewPage : ContentPage
    {
        AlunoViewModel vmAluno;
        public AlunoViewPage()
        {
            var aluno = AlunoViewModel.GetAluno();
            vmAluno = new AlunoViewModel(aluno);

            BindingContext = vmAluno;
            InitializeComponent();
        }
    }
}