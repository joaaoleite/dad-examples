# DAD

### Install for macOS

```sh
# install openssl
brew update
brew install openssl
ln -s /usr/local/opt/openssl/lib/libcrypto.1.0.0.dylib /usr/local/lib/
ln -s /usr/local/opt/openssl/lib/libssl.1.0.0.dylib /usr/local/lib/

# install .NET
brew install Caskroom/cask/dotnet

# symlink to zsh users
ln -s /usr/local/share/dotnet/dotnet /usr/local/bin

# install xamarin and monodevelop
brew tap caskroom/cask
brew cask install mono-mdk
brew cask install xamarin-studio
```

### Start a new .NET  project

* Using command line tool
```sh
# init code
mkdir hwapp
cd hwapp
dotnet new

# run the app
dotnet restore
dotnet run
```

*  Using Xamarin Studio
```
- File -> New -> Solution
- Other -> .NET
- Empty Project
```

