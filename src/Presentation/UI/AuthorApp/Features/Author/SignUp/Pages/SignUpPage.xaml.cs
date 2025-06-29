using AuthorApp.Features.PageModels;
using AuthorApp.Utilities.MVVM;

namespace AuthorApp.Features.Pages;

public partial class SignUpPage : BasePage
{
	public SignUpPage(SignUpPageModel pm)
	{
		BindingContext = pm;
		InitializeComponent();
	}
}