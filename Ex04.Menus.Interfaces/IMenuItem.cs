namespace Ex04.Menus.Interfaces
{
    public interface IMenuItem
    {
        string Name { get; set; }

        void Execute();
    }
}
