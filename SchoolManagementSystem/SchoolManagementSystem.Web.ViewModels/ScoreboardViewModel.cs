namespace SchoolManagementSystem.Web.ViewModels;

public class ScoreboardViewModel
{
    public ICollection<StudentScoreboardViewModel> StudentScores { get; set; } = new List<StudentScoreboardViewModel>();
    public ICollection<ClassScoreboardViewModel> ClassScores { get; set; } = new List<ClassScoreboardViewModel>();
}