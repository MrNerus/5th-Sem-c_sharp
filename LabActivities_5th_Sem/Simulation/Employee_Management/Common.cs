namespace LabActivities_5th_Sem.Simulation.Employee_Management
{
    public abstract class Common
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
    enum Filter_Mode
    {
        Left,
        All,
        Right
    }
}
