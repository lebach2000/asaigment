using asaigment.Entity;
using asaigment.Service;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace asaigment.Pages.AuthenticationPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AccountInfoPage : Page
    {
        private IMemberService _memberService;
        private IFileService _fileService;
        private StorageFile photo;
        public AccountInfoPage()
        {
            this.InitializeComponent();
            this._memberService = new MemberService();
            this._fileService = new LocalFileService();
            this.Loaded += LoadUserInformation;
        }
        private async void LoadUserInformation(object sender, RoutedEventArgs e)
        {
            var memberCredential = await this._fileService.ReadMemberCredentialFromFile();
            if (memberCredential == null)
            {
                this.Frame.Navigate(typeof(LoginPage));
            }

            if (memberCredential != null)
            {
                var member = this._memberService.GetInformation(memberCredential.token);
                FirstName.Text = member.firstName;
                LastName.Text = member.lastName;
                Email.Text = member.email;
                Phone.Text = member.phone;
                Address.Text = member.address;
                Introduction.Text = member.introduction;
                Gender.Text = member.gender == 1 ? "Male" : (member.gender == 0 ? "Female" : "Other");
                Birthday.Text = member.birthday;
            }
        }
    }
}
