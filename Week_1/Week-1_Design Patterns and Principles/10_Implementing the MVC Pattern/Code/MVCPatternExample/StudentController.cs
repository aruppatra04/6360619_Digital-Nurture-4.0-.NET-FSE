public class StudentController
{
    private Student _model;
    private StudentView _view;

    public StudentController(Student model, StudentView view)
    {
        _model = model;
        _view = view;
    }

    // Model setters
    public void SetStudentName(string name) => _model.Name = name;
    public void SetStudentId(string id) => _model.Id = id;
    public void SetStudentGrade(string grade) => _model.Grade = grade;

    // Model getters
    public string GetStudentName() => _model.Name;
    public string GetStudentId() => _model.Id;
    public string GetStudentGrade() => _model.Grade;

    // Update view
    public void UpdateView()
    {
        _view.DisplayStudentDetails(_model.Name, _model.Id, _model.Grade);
    }
}
