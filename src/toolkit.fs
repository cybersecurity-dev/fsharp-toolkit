open System.IO
open System.Security.Cryptography
open System.Text

// useage : let filesha256 = calculate_sha256 "/path/file.txt"
//          printfn "The SHA256 hash is: %s" filesha256
let calculate_sha256 (fpath: string) =
    // Create the SHA256 provider
    use sha256 = SHA256.Create()
    
    // Open the file stream for reading
    use stream = File.OpenRead(fpath)
    
    // Compute the hash from the stream
    let hashBytes = sha256.ComputeHash(stream)
    
    // Convert byte array to a hex string
    hashBytes 
    |> Array.map (fun b -> b.ToString("x2")) 
    |> String.concat ""