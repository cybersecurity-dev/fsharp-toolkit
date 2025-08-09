# [F#](https://en.wikipedia.org/wiki/F_Sharp_(programming_language)) [Toolkit](https://dotnet.microsoft.com/en-us/learn/fsharp) 
[![YouTube](https://img.shields.io/badge/YouTube-%23FF0000.svg?style=for-the-badge&logo=YouTube&logoColor=white)](https://youtube.com/playlist?list=PL9V4Zu3RroiV11_Gq6dZuF1KYJF-jkf1w&si=l_efKG_AbTdD2Voy) [![Reddit](https://img.shields.io/badge/Reddit-FF4500?style=for-the-badge&logo=reddit&logoColor=white)](https://www.reddit.com/r/fsharp/) [![Linux](https://img.shields.io/badge/Linux-FCC624?style=for-the-badge&logo=linux&logoColor=black)](https://github.com/cybersecurity-dev/Bash-Toolkit?tab=readme-ov-file#programming-language) [![Windows](https://custom-icon-badges.demolab.com/badge/Windows-0078D6?style=for-the-badge&logo=windows11&logoColor=white)](https://github.com/cybersecurity-dev/PowerShell-Toolkit?tab=readme-ov-file#programming-language)

<p align="center">
    <a href="https://github.com/cybersecurity-dev/"><img height="25" src="https://github.com/cybersecurity-dev/cybersecurity-dev/blob/main/assets/github.svg" alt="GitHub"></a>
    &nbsp;
    <a href="https://www.youtube.com/@CyberThreatDefence"><img height="25" src="https://github.com/cybersecurity-dev/cybersecurity-dev/blob/main/assets/youtube.svg" alt="YouTube"></a>
    &nbsp;
    <a href="https://cyberthreatdefence.com/my_awesome_lists"><img height="20" src="https://github.com/cybersecurity-dev/cybersecurity-dev/blob/main/assets/blog.svg" alt="My Awesome Lists"></a>
    <img src="https://github.com/cybersecurity-dev/cybersecurity-dev/blob/main/assets/bar.gif">
</p>

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


## [HelloWorld](https://fsharp.org/use/linux/) Project
```bash
dotnet new console -lang F# -o HelloWorld && \
cd ./HelloWorld && \
dotnet run
```
