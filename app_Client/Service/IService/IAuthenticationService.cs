using app_Models;

namespace app_Client.Service.IService
{
	public interface IAuthenticationService
	{
		Task<SignUpResponseDTO> RegisterUser(SignUpRequestDTO signUpRequestDTO);
		Task<SignInResponseDTO> Login(SignInRequestDTO signInRequestDTO);
		Task Logout();
	}
}
