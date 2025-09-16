namespace DataTableApp.Data
{
    public class OrdemServico
{
    public int Os { get; set; }
    public string Cliente { get; set; } = string.Empty;
    public string Placa { get; set; } = string.Empty;
    public string Status { get; set; } = string.Empty;
    public DateTime DataAbertura { get; set; }
    public DateTime? DataFechamento { get; set; }
}

}