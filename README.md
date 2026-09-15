# Cloudflare Workers .NET Examples

Minimal examples for [cloudflare-workers-dotnet](https://github.com/nenoNaninu/cloudflare-workers-dotnet).

## Deploy `HelloFetchWorker`

### Prerequisites

- [.NET 10 SDK](https://dotnet.microsoft.com/download/dotnet/10.0)
- [Node.js 22 or later](https://nodejs.org/)
- [WASI SDK 29](https://github.com/WebAssembly/wasi-sdk/releases/tag/wasi-sdk-29)
- [Cloudflare account](https://dash.cloudflare.com/sign-up)

After extracting the WASI SDK, set `WASI_SDK_PATH` to its directory. For example:

```sh
# macOS or Linux
export WASI_SDK_PATH=/absolute/path/to/wasi-sdk-29.0
```

```powershell
# Windows PowerShell
$env:WASI_SDK_PATH = "C:\path\to\wasi-sdk-29.0"
```

Clone the repository and move to the example project:

```sh
git clone https://github.com/nenoNaninu/Cloudflare.Workers.Hosting.Examples.git
cd Cloudflare.Workers.Hosting.Examples/src/HelloFetchWorker
```

Install Wrangler and the other Node.js dependencies:

```sh
npm install
```

Optionally run the Worker locally, then open <http://localhost:8787>:

```sh
npm run dev
```

Log in to Cloudflare and deploy:

```sh
npm run deploy
```

Wrangler builds the C# project automatically and prints the deployed `workers.dev` URL. Open that URL to see:

```text
Hello from C# on Cloudflare Workers!
```
