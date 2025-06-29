using AuthorApp.Features.PageModels;
using AuthorApp.Utilities.MVVM;

namespace AuthorApp.Features.Pages;

public partial class SignInPage : BasePage
{
	public SignInPage(SignInPageModel pm)
	{
		BindingContext = pm;
		InitializeComponent();
	}
}