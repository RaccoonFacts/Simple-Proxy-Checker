# ProxyChecker v1.0

## Overview
ProxyChecker is a simple Windows Forms application built in C# that allows users to test the validity of proxy servers by checking their connectivity. The tool takes a list of proxies (in the format `IP:Port`), tests each one by attempting to connect to `http://www.google.com`, and categorizes them into working and non-working proxies. It includes a progress bar, placeholder text for ease of use, and a feature to copy working proxies to the clipboard.

## Features
- **Proxy Validation**: Tests proxy servers by making an HTTP request to Google.
- **User-Friendly Interface**: Includes a placeholder in the input field and a progress bar to track the checking process.
- **Results Display**: Separates working and non-working proxies into two distinct lists.
- **Clipboard Support**: Easily copy the list of working proxies with a single click.
- **Error Handling**: Gracefully handles invalid proxy formats and connection timeouts.

## Prerequisites
- **Operating System**: Windows (due to Windows Forms dependency).
- **.NET Framework**: Compatible with .NET Framework (ensure you have the version matching your Visual Studio setup, e.g., 4.8).
- **Visual Studio**: Developed and tested in Visual Studio (2019 or later recommended).

## How to Use
1. **Clone or Download**: Clone this repository or download the source code from GitHub.
   ```bash
   git clone https://github.com/yourusername/ProxyChecker.git
