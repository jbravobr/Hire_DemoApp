namespace ArcTouch.TestApp
{
    public static class Constants
    {
        public const string BaseURLAddress = "https://api.themoviedb.org/3/";
        public const int ResultPerPage = 20;
        public const string RemoteHostForTestConnection = "https://www.google.com";

        //Messages
        public const string MessageLoadingMoviesForTheFirstTime = "Carregando filmes ...";
        public const string MessageLoadingMoreMovies = "Carregando mais filmes ...";
        public const string MessageLoadingMovieDetails = "Carregando informações do filme";
        public const string GeneralErrorMessage = "Desculpe-nos pela inconveniência, tente novamente mais tarde";
        public const string SaveLocalDataErrorMessage = "Oops ... Erro ao salvar dados locais";
        public const string GetLocalDataErrorMessage = "Oops ... Erro ao recuperar dados locais";
        public const string DeleteLocalDataErrorMessage = "Oops ... Erro ao remover dados locais";
        public const string UpdateLocalDataErrorMessage = "Oops ... Erro ao atualizar dados locais";
        public const string CreateDatabaseErrorMessage = "Oops ... Erro ao criar base de dados";
        public const string AssocieateGenreAndMovieErrorMessage = "Oops ... Erro ao tentar identificar o gênero de um filme";
        public const string GetOnlineDataErrorMessage = "Oops ... Erro ao tentar coletar informações do servidor, por favor tente novamente";
        public const string LoadingMovieDetailsErrorMessage = "Oops ... Erro ao tentar carregar informações deste filme";
        public const string LastSessionCrashMessage = "Percebemos que houve um erro com a sua ultima vinda aqui, lamentamos por isto!";
        public const string OfflineMessage = "Desculpe, mas para utilizar este recurso você precisa estar conectado a internet";
    }
}