namespace AppGetSameFiles.resources.abstract_class
{
    public abstract class AbstracBox<T>
    {
        protected T box;
        protected string source;
        protected void SetSource(string _path) => source = _path;
        public string GetSource() { return source; }


        public T GetBox()
        {
            return box;
        }

        public abstract void BoxIsEnable(bool _bln);

        public void SetBox(T _box) => box = _box;

        public abstract bool BoxIsNotEmpty();

        public AbstracBox(T _box)
        {
            SetBox(_box);
            Fill();
        }

        public abstract void Fill();
    }
}