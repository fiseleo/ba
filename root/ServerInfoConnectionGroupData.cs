using Newtonsoft.Json;

public class ServerInfoConnectionGroupData
{
    [JsonProperty]
    public string Name { get; set; }

    [JsonProperty]
    public string ManagementDataUrl { get; set; }

    [JsonProperty]
    public string AddressablesCatalogUrlRoot { get; set; }

    [JsonProperty]
    public bool? IsProductionAddressables { get; set; }

    [JsonProperty]
    public string ApiUrl { get; set; }

    [JsonProperty]
    public string GatewayUrl { get; set; }

    [JsonProperty]
    public string KibanaLogUrl { get; set; }

    [JsonProperty]
    public string ChattingServerAddress { get; set; }

    [JsonProperty]
    public string ProhibitedWordBlackListUri { get; set; }

    [JsonProperty]
    public string ProhibitedWordWhiteListUri { get; set; }

    [JsonProperty]
    public string CustomerServiceUrl { get; set; }

    [JsonProperty]
    public string BundleVersion { get; set; }

    [JsonProperty]
    public ServerInfoConnectionGroupData[] OverrideConnectionGroups { get; set; }

    public ServerInfoConnectionGroupData GetOverrided(string version)
    {
        return null;
    }

    public ServerInfoConnectionGroupData() { }
}
