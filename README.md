# Caesar Cipher Application

## Overview

This application is a WPF (Windows Presentation Foundation) desktop app developed using .NET 6.0. It implements the Caesar cipher, an ancient encryption technique for encoding text by shifting each letter a certain number of places down the alphabet. This particular implementation is tailored to the Polish language, accommodating the unique characters found in the Polish alphabet.

## Features

- **Text Encryption**: Allows users to encrypt text input using the Caesar cipher method.
- **Text Decryption**: Enables users to decrypt previously encrypted text, assuming the correct shift value is known.
- **Polish Language Support**: Specifically designed to handle the Polish alphabet, including special characters (e.g., ą, ć, ę, ł, ń, ó, ś, ź, ż).

## Requirements

- .NET 6.0 SDK
- Windows OS with support for WPF applications

## Installation

1. **Clone the repository**: First, clone the repo to your local machine using Git.
   git clone https://github.com/xjustride/Szyfr-cezaraWPF.git

2. **Open the project**: Open the `.sln` file in Visual Studio or your preferred IDE that supports .NET 6.0 development.

3. **Build the application**: Compile the application within your IDE or using the .NET CLI.
dotnet build
4. **Run the application**: Start the application from your IDE, or use the .NET CLI to run it.
dotnet run

## Usage

To use the Caesar cipher application:

1. **Enter the text**: Type the text you wish to encrypt or decrypt into the input text area.
2. **Set the shift value**: Specify the number of positions each letter should be shifted in the alphabet.
3. **Encrypt/Decrypt**: Click the "Encrypt" button to encode your text, or the "Decrypt" button to decode it.
4. **View the result**: The result of the encryption or decryption process will be displayed in the output area.

## License

This project is licensed under the MIT License - see the [LICENSE](LICENSE.md) file for details.




