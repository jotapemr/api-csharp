namespace desafio_api_cadastro.Dto
{
    public class UserDto
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public bool IsAdmin { get; set; }
    }
}
