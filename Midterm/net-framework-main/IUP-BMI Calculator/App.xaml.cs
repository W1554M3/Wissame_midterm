using IUP_BMI_Calculator.Repository;

namespace IUP_BMI_Calculator;

public partial class App : Application
{
	public BMIResultRepository BMIResultRepository;
	public App(string dbPath)
	{
		InitializeComponent();

		MainPage = new AppShell();

		BMIResultRepository._dbPath = dbPath;
		BMIResultRepository.conn = new SQLite.SQLiteConnection(dbPath);
	}
}
