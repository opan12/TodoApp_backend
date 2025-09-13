TodoApp Backend

Bu proje, .NET 8 ve C# kullanılarak geliştirilmiş bir Todo uygulaması backend servisleri örneğidir. Servisler, Docker ile konteynerleştirilmiş ve birden fazla servisin birlikte çalışması docker-compose.yml ile sağlanmıştır. Tüm API’ler REST standartlarına uygundur.

Proje Yapısı

TodoApp.api: API servisleri

TodoApp_backend.sln: Visual Studio çözüm dosyası

docker-compose.yml: Servisleri bir arada çalıştırmak için yapılandırma

.dockerignore: Docker konteyneri oluşturulurken hariç tutulacak dosyalar

.gitignore: Git tarafından izlenmeyecek dosyalar

Kullanılan Teknolojiler

Bu projede mikroservislerin yönetimi ve geliştirilmesi için birden fazla teknoloji kullanılmıştır. Backend servisleri geliştirmek için .NET 7 ve C# tercih edilmiştir. Servisler arası veri taşımak ve yönetmek için DTO (Data Transfer Object) yapıları kullanılmıştır.

Projede servislerin bağımsız ve taşınabilir şekilde çalışabilmesi için Docker kullanılmıştır. Birden fazla servisi birlikte çalıştırmak ve yönetmek için Docker Compose kullanılmıştır. API isteklerini yönlendirmek ve servisler arası iletişimi sağlamak için YARP (Yet Another Reverse Proxy) kullanılmıştır. Tüm servisler REST API standartlarına uygun olarak geliştirilmiştir.
