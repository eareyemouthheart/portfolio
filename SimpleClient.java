import java.io.*;
import java.net.Socket;

public class SimpleClient {
    public static void main(String[] args) {
        OutputStream os = null;
        PrintWriter pw = null;
        InputStream is = null;
        BufferedReader br = null;
        Socket socket = null;
        try {
            // create a connection with the server
            socket = new Socket("119.45.61.165", 0);

            // send information to server
            os = socket.getOutputStream();
            pw = new PrintWriter(os);
            if (args == null || args.length == 0) {
                System.err.println("Please input your name!");
                return;
            }
            pw.write(args[0]);
            pw.flush();
            socket.shutdownOutput();

            // received information from the server
            is = socket.getInputStream();
            br = new BufferedReader(new InputStreamReader(is));
            String info = null;
            while ((info = br.readLine()) != null) {
                System.out.println(info);
            }
        } catch (IOException e) {
            e.printStackTrace();
        } finally {
            try {
                // close resources
                if (br != null)
                    br.close();
                if (is != null)
                    is.close();
                if (os != null)
                    os.close();
                if (pw != null)
                    pw.close();
                if (socket != null)
                    socket.close();
            } catch (IOException e) {
                e.printStackTrace();
            }
        }
    }
}
