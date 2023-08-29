namespace PlatformService.Dtos
{
    //DTOs => patrón utilizado en el desarrollo para transferir datos entre diferentes componentes de una aplicación.
    public class PlatformReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Cost { get; set; }
    }
}
