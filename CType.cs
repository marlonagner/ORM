public abstract class CType : IType
{
    public virtual void Save()
    {
       new Service(this).Save();
    }

}