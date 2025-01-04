# dotnet-conf-2025-nodejs-api-dotnet

## Abstract

This project demonstrates the integration of .NET with Node.js using the `node-api-dotnet` package. It includes examples of invoking .NET methods from Node.js and using P/Invoke to call native system functions on macOS.

## Project Structure

- `ts-dotnet`: TypeScript project demonstrating basic .NET integration.
- `ts-dotnet-pinvoke`: TypeScript project demonstrating P/Invoke with .NET.
- `js-dotnet`: JavaScript project demonstrating basic .NET integration.
- `js-dotnet-pinvoke`: JavaScript project demonstrating P/Invoke with .NET.
- `ts-dotnet-intellisense`: TypeScript project with IntelliSense support for .NET methods.
- `pinvoke-macos`: .NET library for P/Invoke on macOS.
- `pinvoke-macos-sample`: Sample .NET application using `pinvoke-macos`.

## How to Build

### Prerequisites

- Node.js (v18 or later)
- .NET SDK (v8.0 or later)
- TypeScript (for TypeScript projects)

### Steps

1. Clone the repository:
    ```sh
    git clone https://github.com/your-repo/dotnet-conf-2025-nodejs-api-dotnet.git
    cd dotnet-conf-2025-nodejs-api-dotnet
    ```

2. Install dependencies for each project:
    ```sh
    cd ts-dotnet
    npm install
    cd ../ts-dotnet-pinvoke
    npm install
    cd ../js-dotnet
    npm install
    cd ../js-dotnet-pinvoke
    npm install
    cd ../ts-dotnet-intellisense
    npm install
    ```

3. Build the TypeScript projects:
    ```sh
    cd ts-dotnet
    npm run build
    cd ../ts-dotnet-pinvoke
    npm run build
    cd ../ts-dotnet-intellisense
    npm run build
    ```

4. Build the .NET projects:
    ```sh
    cd pinvoke-macos
    dotnet build
    cd ../pinvoke-macos-sample
    dotnet build
    cd ../ts-dotnet-intellisense/MyDotnetClass
    dotnet build
    ```

## How to Run

### JavaScript Projects

1. Run `js-dotnet`:
    ```sh
    cd js-dotnet
    npm start
    ```

2. Run `js-dotnet-pinvoke`:
    ```sh
    cd js-dotnet-pinvoke
    npm start
    ```

### TypeScript Projects

1. Run `ts-dotnet`:
    ```sh
    cd ts-dotnet
    npm start
    ```

2. Run `ts-dotnet-pinvoke`:
    ```sh
    cd ts-dotnet-pinvoke
    npm start
    ```

3. Run `ts-dotnet-intellisense`:
    ```sh
    cd ts-dotnet-intellisense
    npm start
    ```

### .NET Sample Project

1. Run `pinvoke-macos-sample`:
    ```sh
    cd pinvoke-macos-sample
    dotnet run
    ```

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for details.