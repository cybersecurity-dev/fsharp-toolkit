# [F#](https://fsharp.org/use/linux/) [Toolkit](https://dotnet.microsoft.com/en-us/learn/fsharp) [![YouTube](https://img.shields.io/badge/YouTube-%23FF0000.svg?style=for-the-badge&logo=YouTube&logoColor=white)](https://youtube.com/playlist?list=PL9V4Zu3RroiV11_Gq6dZuF1KYJF-jkf1w&si=l_efKG_AbTdD2Voy)

## Install Steps
<details>

<summary>For Debian, Ubuntu, Linux Mint</summary>

```bash
wget https://packages.microsoft.com/config/debian/12/packages-microsoft-prod.deb -O packages-microsoft-prod.deb && \
sudo dpkg -i packages-microsoft-prod.deb
```

```bash
rm packages-microsoft-prod.deb && \
sudo apt-get update && \
sudo apt-get install -y dotnet-sdk-9.0 
```

```bash
sudo dotnet workload update && \
dotnet --version
```

</details>


<details>
 
 <summary>For RHEL, Fedora, AlmaLinux</summary>
  
 ```bash
 sudo dnf update
 ```
 </details>

 <details>
 <summary>For Arch, Manjaro, EndeavourOS</summary>
  
 ```bash
sudo pacman -Syu
 ```
 </details>


## HelloWorld Project
```bash
dotnet new console -lang F# -o HelloWorld && \
cd ./HelloWorld && \
dotnet run
```
