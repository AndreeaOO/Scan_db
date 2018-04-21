using System;
using System.Threading.Tasks;
using Dropbox.Api;

class DropBox {
    public static void InitClient(){
        var task = Task.Run((Func<Task>)Program.run);
        task.Wait();
    }
    static async Task.Run()
    using (var dbx=new DropboxClient("kvV3uLWjyqAAAAAAAAAAB_rUpZkAJqx9zaVe2PztBX60BpxjvRHRuzH2p_i6A3PE")){
        var full=await.dbx.Users.GetConcurrentAsscountAsync();
        Console.Writeline("{0} - {1}", full.Name.DisplayName, full.Email)
        }
    }
    async Task Upload(DropboxClient dbx, string folder, string file, string content){
        using (var mem = new MemoryStream(Encoding.UTF8.GetBytes(content))){
            var updated = await dbx.Files.UploadAsync(
                folder + "/" + file,
                WriteMode.Overwrite.Instance,
                body: mem);
            Console.WriteLine("Saved {0}/{1} rev {2}", folder, file, updated.Rev)    
        }
    }

}