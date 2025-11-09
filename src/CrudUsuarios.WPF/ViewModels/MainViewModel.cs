using CrudUsuarios.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace CrudUsuarios.WPF.ViewModels;

public class MainViewModel
{
    private readonly HttpClient _http = new() { BaseAddress = new Uri("https://localhost:5001/api/v1/users/") };
    public ObservableCollection<User> Users { get; set; } = new();

    public async Task LoadUsersAsync()
    {
        var data = await _http.GetFromJsonAsync<List<User>>("");
        Users.Clear();
        foreach (var u in data!) Users.Add(u);
    }
}