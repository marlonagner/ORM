
public interface IType : IConnectionString
{

[Table(PrimaryKey = "Id")]
 public virtual  int Id { get; set; }

}