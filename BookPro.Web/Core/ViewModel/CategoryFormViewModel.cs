namespace BookPro.Web.Core.ViewModel;

public class CategoryFormViewModel
{
    public int Id {  get; set; }

    [MaxLength(100),MinLength(3,ErrorMessage ="the lenthg ")]
    public string Name { get; set; } = null!;
}
