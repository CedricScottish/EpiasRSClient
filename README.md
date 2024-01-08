# EPİAŞ Şeffaflık Platformu 2.0 Elektrik Piyasası Raporları Web Servisleri 
# EXIST Transparency Platform 2.0 Electricity Market Reports Web Services


> [!IMPORTANT] 
> EPİAŞ tarafından Şeffaflık Platformu 2.0 ile 04 Aralık 2023 tarihinde güncellenen web servisleri kullanıma açılmıştır. Eski ve yeni web servisleri 1 Mart 2024 tarihine kadar hizmet vermeye devam edecek olup sonraki süreçte yeni web servisleri ile hizmet verilecektir.  [EPİAŞ Duyuru](https://www.epias.com.tr/tum-duyurular/piyasa-duyurulari/elektrik/web-servis/seffaflik-platformu-web-servisleri-erisim-tarihi-hakkinda-guncelleme/)



## Simple Code Usage Example

```C#
using EpiasReportingServiceClient;
….
    try
    {
        //initialize web service client
        EpiasRSAPIClient client = new EpiasRSAPIClient(new HttpClient());
        //set all required values
        GunlukFiyatRequestDto body = new GunlukFiyatRequestDto();                
        body.Date = DateTime.Now.AddDays(-1);
         //call the service
        GunlukFiyatResponseDto response = await client.DailyPricesAsync(body);
        // show the data
        dataGridView1.DataSource = response.Items;

    }
    catch (ApiException ex)
    {
        MessageBox.Show(ex.Message.ToString());
    }

```
## Sample MCP Data 
![DailyPriceSS](https://github.com/CedricScottish/EpiasRSClient/assets/61628447/d34fb687-6b7d-4684-bcb7-ebee1f8e64fa)


## Dependence
- Newtonsoft.Json [Official Site](https://www.newtonsoft.com/json)
## Reference 
- https://seffaflik.epias.com.tr/reporting-service/technical/tr/index.html
