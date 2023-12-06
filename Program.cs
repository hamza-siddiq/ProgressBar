using ProgressBar;
namespace ProgressBar{

class Program
{
    static void Main(string[] args)
    {
        int count = 30;
        var progressbar = new ProgressBar(count);
        for (var i = count; i > 0; i--){
            progressbar.Tick();
        }
    }
}
}
