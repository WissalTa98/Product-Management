using Microsoft.JSInterop;

namespace app_Client.Helper
{
	public static class IJSRuntimeExtension
	{
		public static async ValueTask ToastrSuccess(this IJSRuntime jsRuntime, string message)
		{
			await jsRuntime.InvokeVoidAsync("ShowToastr", "success", message);
		}

		public static async ValueTask ToastrError(this IJSRuntime jsRuntime, string message)
		{
			await jsRuntime.InvokeVoidAsync("ShowToastr", "error", message);
		}

		public static async ValueTask SweetAlertSuccess(this IJSRuntime jsRuntime)
		{
			await jsRuntime.InvokeVoidAsync("ShowSweetAlert", "success");
		}

		public static async ValueTask SweetAlertFailed(this IJSRuntime jsRuntime)
		{
			await jsRuntime.InvokeVoidAsync("ShowSweetAlert", "error");
		}


	}
}
