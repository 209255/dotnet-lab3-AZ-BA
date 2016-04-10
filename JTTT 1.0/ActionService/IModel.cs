namespace JTTT_1._0
{
    public abstract  class IModel
    {
        public int Id { get; set; }
        public string URL { get; set; }

        // public virtual Task Task { get; set; }
        public abstract void FillModel(string[] args);
        public abstract void Complemet(string[] args);
    }
}
