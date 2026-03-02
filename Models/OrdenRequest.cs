public class OrdenRequest
{
    public string nombreOrden { get; set; }
    public List<DetalleOrdenRequest> detalles { get; set; }
}

public class DetalleOrdenRequest
{
    public int idPlatillo { get; set; }
    public int cantidad { get; set; }
    public string comentarios { get; set; }
    public decimal precioUnitario { get; set; }
}