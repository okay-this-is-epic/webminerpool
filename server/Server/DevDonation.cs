// The MIT License (MIT)

// Copyright (c) 2018 - the webminerpool developer

// Permission is hereby granted, free of charge, to any person obtaining a copy of
// this software and associated documentation files (the "Software"), to deal in
// the Software without restriction, including without limitation the rights to
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do so,
// subject to the following conditions:

// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.

// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, FITNESS
// FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR
// COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER
// IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN
// CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.

namespace Server {

    public static class DevDonation {

        // by default a 3% dev fee is submitted to the following address.
        // thank you for leaving this in.
        //Ok this is notgiven's DevAddress
        //I'm going to put it back in depending if we can have more than one donation DevPoolPwd
        //And based on his GLPv2 response determines how motivated I am to look into that. -Felty
        //public const double DonationLevel = 0.03;
        //public const string DevAddress = "49kkH7rdoKyFsb1kYPKjCYiR2xy1XdnJNAY1e7XerwQFb57XQaRP7Npfk5xm1MezGn2yRBz6FWtGCFVKnzNTwSGJ3ZrLtHU";
        //public const string DevPoolUrl = "gulf.moneroocean.stream";
        //public const string DevPoolPwd = "x"; // if you want, you can change this to something funny
        //public const int DevPoolPort = 10064;

        // Below is the VidYen, LLC address
        // If you want to leave it in that's fine with you, but its for people connecting to vy256.com pool but not mining for us directly
        //As VYPS people might be mining to their own address. Hrm... I got to fix that so they can. -Felty
        //Oh yeah. I'm using 6 because of some other meta we are handling. Feel free to download and change this though on your own server.
        public const double DonationLevel = 0.04;
        public const string DevAddress = "4AgpWKTjsyrFeyWD7bpcYjbQG7MVSjKGwDEBhfdWo16pi428ktoych4MrcdSpyH7Ej3NcBE6mP9MoVdAZQPTWTgX5xGX9Ej";
        public const string DevPoolUrl = "gulf.moneroocean.stream";
        public const string DevPoolPwd = "x"; //Fabius did nothing wrong. I'm not sure if this is an issue though.
        public const int DevPoolPort = 10002;

    }


}
