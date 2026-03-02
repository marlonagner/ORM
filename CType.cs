public abstract CType : IType
{
    public void Salvar()
    {
       new Service(this).Salvar();
    }

}