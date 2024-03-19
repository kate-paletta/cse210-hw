public class MathAssignment : Assignment
{
    private string _txtbookSect;
    private string _problems;
    public string GetTxtBookSect()
    {
        return _txtbookSect;
    }
    public void SetTxtBookSect(string txtbookSect)
    {
        _txtbookSect = txtbookSect;
    }
    public string GetProblems()
    {
        return _problems;
    }
    public void SetProblems(string problems)
    {
        _problems = problems;
    }
    public string GetHwList()
    {
        return $"{_studentName} - {_topic}\nSection {_txtbookSect} Problems {_problems}";
    }
}