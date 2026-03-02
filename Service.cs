public class Service
{
    private string connectionString;
    private IType iType;
   
   public Service(IType iType)
   {
      this.iType = iType;
      this.connectionString = this.iType.ConnectionString;

   }

   public virtual void Salvar()
   {
      throw new NotImplementedException();
      
   }


}
