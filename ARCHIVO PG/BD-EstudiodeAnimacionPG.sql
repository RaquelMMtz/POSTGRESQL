CREATE TABLE Animatic2D
(
idAnimatic2D serial primary key,
fechaEntrega timestamp NOT NULL,
personaje VARCHAR (50) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE ArteConceptual
(
 idArteConceptual serial primary key,
 concepto VARCHAR (50),
 fechaEntrega timestamp NOT NULL,
 estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE Cambio
(
idCambio SERIAL PRIMARY KEY,
cambio VARCHAR (50) NOT NULL,
descripcion VARCHAR (100) NOT NULL,
fecha TIMESTAMP NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE Director
(
idDirector SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE Ingreso
(
idIngreso SERIAL PRIMARY KEY,
ingreso INT NOT NULL,
descripcion VARCHAR (50) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE JuntaDirectiva
(
idJuntaDirectiva SERIAL PRIMARY KEY,
motivo VARCHAR (50) NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Layout
(
idLayout SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
correccionDibujo VARCHAR (50) NOT NULL,
tipo VARCHAR (30),
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE Musico
(
idMusico SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
tipoMusica VARCHAR (30) NOT NULL, 
estatus BOOLEAN NOT NULL DEFAULT TRUE
);
CREATE TABLE PostProduccion
(
idPostProduccion SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
correccionFinal VARCHAR (100) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);
CREATE TABLE StoryBoard
(
idStoryBoard SERIAL PRIMARY KEY,
tituloEscena VARCHAR (30) NOT NULL,
ideaEscena VARCHAR (50) NOT NULL,
fechaEntrega TIMESTAMP NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);
CREATE TABLE VFX
(idVFX SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
tipo VARCHAR (50) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE Actor
(
idActor SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
personaje VARCHAR (30) NOT NULL, 
idDirector INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE AsistenteAnimacion
(
idAsistenteAnimacion SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
idDirector INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Animacion
(
idAnimacion SERIAL PRIMARY KEY,
nombre VARCHAR (30) NOT NULL,
fechaEntrega TIMESTAMP NOT NULL,
idAsistenteAnimacion INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Animador
(
idAnimador SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
especializacion VARCHAR (50) NOT NULL,
idDirector INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Artista
(
idArtista SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
especializacion VARCHAR (50) NOT NULL,
idDirector INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Colaboracion
(
idColaboracion SERIAL PRIMARY KEY,
estudio VARCHAR (50) NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
idJuntaDirectiva INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE ColorScript
(
idColorScript SERIAL PRIMARY KEY,
descripcion VARCHAR (50) NOT NULL,
fechaEntrega TIMESTAMP NOT NULL,
idArtista INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
 ;
CREATE TABLE Tecnico
(
idTecnico SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
especializacion VARCHAR (50) NOT NULL,
idDirector INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE Compositing
(
idCompositing SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE CorreccionColor
(
idCorreccionColor SERIAL PRIMARY KEY,
descripcion VARCHAR (50) NOT NULL,
fechaEntrega TIMESTAMP NOT NULL,
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE DiaPresentacion
(
idDiaPresentacion SERIAL PRIMARY KEY,
descripcion VARCHAR (50) NOT NULL,
fecha TIMESTAMP NOT NULL,
idJuntaDirectiva INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE  Directivo
(
idDirectivo SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
departamento VARCHAR (50) NOT NULL,
idJuntaDirectiva INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE Esqueletizacion
(
idEsqueletizacion SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE Gerente 
(
idGerente SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
departamento VARCHAR (50) NOT NULL,
idDirectivo INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE ExhibicionInternacional
(
idExhibicionInternacional SERIAL PRIMARY KEY,
feha TIMESTAMP NOT NULL,
calle VARCHAR (50) NOT NULL,
numero CHAR (100) NOT NULL,
colonia VARCHAR (50) NOT NULL,
ciudad VARCHAR (50) NOT NULL,
pais VARCHAR (50) NOT NULL,
idGerente INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);
 
CREATE TABLE ExhibicionNacional
(
idExhibicionNacional SERIAL PRIMARY KEY,
feha TIMESTAMP NOT NULL,
calle VARCHAR (50) NOT NULL,
numero CHAR (100) NOT NULL,
colonia VARCHAR (50) NOT NULL,
ciudad VARCHAR (50) NOT NULL,
codiPostal CHAR (6) NOT NULL,
idGerente INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);
 
CREATE TABLE Fondista
(
idFondista SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
idDirector INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);
 
CREATE TABLE FxPersonaje
(
idFxPersonaje SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE GrabacionVoz
(
idGrabacionVoz SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Guionista
(
idGuionista SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
idGerente INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Guion
(
idGuion SERIAL PRIMARY KEY,
titulo VARCHAR (30) NOT NULL,
fechaEntrega TIMESTAMP NOT NULL,
idGuionista INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
)
;
CREATE TABLE Idea
(
idIdea SERIAL PRIMARY KEY,
propuesta VARCHAR (100) NOT NULL,
fechaEntrega TIMESTAMP NOT NULL,
idJuntaDirectiva INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Iluminacion
(
idIluminacion SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
descripcion VARCHAR (50),
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Masterizacion
(
idMasterizacion SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
tipoAudio VARCHAR (30),
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE MattePainting
(
idMattePainting SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
idFondista INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Modelado
(
idModelado SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
idAsistenteAnimacion INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Musica
(
idMusica SERIAL PRIMARY KEY,
nombre VARCHAR (30)NOT NULL,
genero VARCHAR (30)NOT NULL,
fechaEntrega TIMESTAMP NOT NULL,
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Patrocinador
(
idPatrocinador SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
empresa VARCHAR (30) NOT NULL,
idJuntaDirectiva INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Pelicula
(
idPelicula SERIAL PRIMARY KEY,
titulo VARCHAR (30) NOT NULL,
genero VARCHAR (30) NOT NULL,
clasificacion VARCHAR (6) NOT NULL,
duracion CHAR (150) NOT NULL,
idJuntaDirectiva INT NOT NULL,
idDirector INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE PreExhibicion
(
idPreExhibicion SERIAL PRIMARY KEY,
feha TIMESTAMP NOT NULL,
calle VARCHAR (50) NOT NULL,
numero CHAR (100) NOT NULL,
colonia VARCHAR (50) NOT NULL,
ciudad VARCHAR (50) NOT NULL,
codiPostal CHAR (6) NOT NULL,
numParticipantes CHAR (100) NOT NULL,
idGerente INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Presupuesto
(
idPresupuesto SERIAL PRIMARY KEY,
desarrolloInv INT NOT NULL,
areaTecnica INT NOT NULL, 
areaArtistica INT NOT NULL,
marketing INT NOT NULL,
idGerente INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Productor
(
idProductor SERIAL PRIMARY KEY,
nombre VARCHAR (50) NOT NULL,
apellidoPaterno VARCHAR (50) NOT NULL,
apellidoMaterno VARCHAR (50) NOT NULL,
idGerente INT NOT NULL,
idDirector INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Publicidad
(
idPublicidad SERIAL PRIMARY KEY,
medioTransimicion VARCHAR (30),
precio INT NOT NULL,
idGerente INT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE PulidoCamara
(
idPulidoCamara SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
detalles VARCHAR (100),
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Rediseño
(
idRediseño SERIAL PRIMARY KEY,
primerRediseño TIMESTAMP NOT NULL,
segundoRediseño TIMESTAMP NOT NULL,
idDirector INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Revision
(
idRevision SERIAL PRIMARY KEY,
primeraRevision TIMESTAMP NOT NULL,
segundaRevision TIMESTAMP NOT NULL,
idDirector INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE SetDressing
(
idSetDressing SERIAL PRIMARY KEY,
fechaEntrega TIMESTAMP NOT NULL,
idFondista INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE SFX
(
idSFX SERIAL PRIMARY KEY,
tipo VARCHAR (50) NOT NULL,
fechaEntrega TIMESTAMP NOT NULL,
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE Texturizado
(
idTexturizado SERIAL PRIMARY KEY,
tipo  VARCHAR (50) NOT NULL,
fechaEntrega TIMESTAMP NOT NULL,
idTecnico INT NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE ActorGrabacionVoz
(
idActorGrabacionVoz SERIAL PRIMARY KEY,
idActor INT NOT NULL,
idGrabacionVoz INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE AnimacionAnimador
(
idAnimacionAnimador SERIAL PRIMARY KEY,
idAnimacion INT NOT NULL,
idAnimador INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE AnimadorAnimatic2D
(
idAnimadorAnimatic2D SERIAL PRIMARY KEY,
idAnimador INT NOT NULL,
idAnimatic2D INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE AnimadorModelo
(
idAnimadorModelo SERIAL PRIMARY KEY,
idAnimador INT NOT NULL,
idModelado INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE ArtistaAreaConceptual
(
idArtistaAreaConceptual SERIAL PRIMARY KEY,
idArtista INT NOT NULL,
idArteConceptual INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE ArtistaStoryBoard
(
idArtistaStoryBoard SERIAL PRIMARY KEY,
idArtista INT NOT NULL,
idStoryBoard INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE CambioDirectivo
(
idCambioDirectivo SERIAL PRIMARY KEY,
idCambio INT NOT NULL,
idDirectivo INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE DirectorGerente
(
idDirectorGerente SERIAL PRIMARY KEY,
idDirector INT NOT NULL,
idGerente INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE IngresoExhibicionInternacional
(
idIngresoExhibicionInternacional SERIAL PRIMARY KEY,
idIngreso INT NOT NULL,
idExhibicionInternacional INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);
 
CREATE TABLE IngresoExhibicionNacional
(
idIngresoExhibicionNacional SERIAL PRIMARY KEY,
idIngreso INT NOT NULL,
idExhibicionNacional INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE  LayoutTecnico
(
idLayoutTecnico SERIAL PRIMARY KEY,
idLayout INT NOT NULL,
idTecnico INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE MusicaMusico
(
idMusicaMusico SERIAL PRIMARY KEY,
idMusica INT NOT NULL,
idMusico INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE PostProduccionTecnico
(
idPostProduccionTecnico SERIAL PRIMARY KEY,
idPostProduccion INT NOT NULL,
idTecnico INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);

CREATE TABLE VFXTecnico
(
idVFXTecnico SERIAL PRIMARY KEY,
idVFX INT NOT NULL,
idTecnico INT NOT NULL,
numIntegrantes CHAR (30) NOT NULL,
estatus BOOLEAN NOT NULL DEFAULT TRUE
);



--LLAVES FOREANEAS
--ACTOR
ALTER TABLE Actor ADD CONSTRAINT FK_ActorDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
--ASISTENTEANIMACION
ALTER TABLE AsistenteAnimacion ADD CONSTRAINT FK_AsistenteAnimacionDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
--ANIMACION
ALTER TABLE Animacion ADD CONSTRAINT FK_AnimacionAsistenteAnimacion FOREIGN KEY(idAsistenteAnimacion) REFERENCES AsistenteAnimacion(idAsistenteAnimacion);
--ANIMADOR
ALTER TABLE Animador ADD CONSTRAINT FK_AnimadorDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
--ARTISTA
ALTER TABLE Artista ADD CONSTRAINT FK_ArtistaDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
--Colaboracion
ALTER TABLE Colaboracion ADD CONSTRAINT FK_ColaboracionJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
--ColorScript
ALTER TABLE ColorScript ADD CONSTRAINT FK_ColorScriptArtista FOREIGN KEY(idArtista) REFERENCES Artista(idArtista);
--Tecnico
ALTER TABLE Tecnico ADD CONSTRAINT FK_TecnicoDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
--Compositing
ALTER TABLE Compositing ADD CONSTRAINT FK_CompositingTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--CorreccionColor
ALTER TABLE CorreccionColor ADD CONSTRAINT FK_CorreccionColorTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--DiaPresentacion
ALTER TABLE DiaPresentacion ADD CONSTRAINT FK_DiaPresentacionJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
--Directivo
ALTER TABLE Directivo ADD CONSTRAINT FK_DirectivoJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
--Esqueletizacion
ALTER TABLE Esqueletizacion ADD CONSTRAINT FK_EsqueletizacionTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--Gerente
ALTER TABLE Gerente ADD CONSTRAINT FK_GerenteDirectivo FOREIGN KEY(idDirectivo) REFERENCES Directivo(idDirectivo);
--ExhibicionInternacional
ALTER TABLE ExhibicionInternacional ADD CONSTRAINT FK_ExhibicionInternacionalGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
--ExhibicionNacional
ALTER TABLE ExhibicionNacional ADD CONSTRAINT FK_ExhibicionNacionalGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
--Fondista
ALTER TABLE Fondista ADD CONSTRAINT FK_FondistaDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
--FxPersonaje
ALTER TABLE FxPersonaje ADD CONSTRAINT FK_FxPersonajeTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--GrabacionVoz
ALTER TABLE GrabacionVoz ADD CONSTRAINT FK_GrabacionVozTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--Guionista
ALTER TABLE Guionista ADD CONSTRAINT FK_GuionistaGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
--Guion;
ALTER TABLE Guion ADD CONSTRAINT FK_GuionGuionista FOREIGN KEY(idGuionista) REFERENCES Guionista(idGuionista);
--Idea
ALTER TABLE Idea ADD CONSTRAINT FK_IdeaJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
--Iluminacion
ALTER TABLE Iluminacion ADD CONSTRAINT FK_IluminacionTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--Masterizacion
ALTER TABLE Masterizacion ADD CONSTRAINT FK_MasterizacionTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--MattePainting
ALTER TABLE MattePainting ADD CONSTRAINT FK_MattePaintingFondista FOREIGN KEY(idFondista) REFERENCES Fondista(idFondista);
--Modelado
ALTER TABLE Modelado ADD CONSTRAINT FK_ModeladoAsistenteAnimacion FOREIGN KEY(idAsistenteAnimacion) REFERENCES AsistenteAnimacion(idAsistenteAnimacion);
--Musica
ALTER TABLE Musica ADD CONSTRAINT FK_MusicaTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--Patrocinador
ALTER TABLE Patrocinador ADD CONSTRAINT FK_PatrocinadorJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
--Pelicula
ALTER TABLE Pelicula ADD CONSTRAINT FK_PeliculaJuntaDirectiva FOREIGN KEY(idJuntaDirectiva) REFERENCES JuntaDirectiva(idJuntaDirectiva);
ALTER TABLE Pelicula ADD CONSTRAINT FK_PeliculaDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
--PreExhibicion
ALTER TABLE PreExhibicion ADD CONSTRAINT FK_PreExhibicionGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
--Presupuesto
ALTER TABLE Presupuesto ADD CONSTRAINT FK_PresupuestoGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
--Productor
ALTER TABLE Productor ADD CONSTRAINT FK_ProductorGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
ALTER TABLE Productor ADD CONSTRAINT FK_ProductorDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
--Pubilicidad
ALTER TABLE Publicidad ADD CONSTRAINT FK_PubilicidadGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
--PulidoCamara
ALTER TABLE PulidoCamara ADD CONSTRAINT FK_PulidoCamaraTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--Rediseño
ALTER TABLE Rediseño ADD CONSTRAINT FK_RediseñoDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
--Revision
ALTER TABLE Revision ADD CONSTRAINT FK_RevisionDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
--SetDressing
ALTER TABLE SetDressing ADD CONSTRAINT FK_SetDressingFondista FOREIGN KEY(idFondista) REFERENCES Fondista(idFondista);
--SFX
ALTER TABLE SFX ADD CONSTRAINT FK_SFXTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--Texturizado
ALTER TABLE Texturizado ADD CONSTRAINT FK_TexturizadoTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--ActorGrabacionVoz
ALTER TABLE ActorGrabacionVoz ADD CONSTRAINT FK_ActorGrabacionVozActor FOREIGN KEY(idActor) REFERENCES Actor(idActor);
ALTER TABLE ActorGrabacionVoz ADD CONSTRAINT FK_ActorGrabacionVozGrabacionVoz FOREIGN KEY(idGrabacionVoz) REFERENCES GrabacionVoz(idGrabacionVoz);
--AnimacionANimador
ALTER TABLE AnimacionAnimador ADD CONSTRAINT FK_AnimacionAnimadorAnimacion FOREIGN KEY(idAnimacion) REFERENCES Animacion(idAnimacion);
ALTER TABLE AnimacionAnimador ADD CONSTRAINT FK_AnimacionAnimadorAnimador FOREIGN KEY(idAnimador) REFERENCES Animador(idAnimador);
--AnimadorAnimatic 2D
ALTER TABLE AnimadorAnimatic2D ADD CONSTRAINT FK_AnimadorAnimatic2DAnimador FOREIGN KEY(idAnimador) REFERENCES Animador(idAnimador);
ALTER TABLE AnimadorAnimatic2D ADD CONSTRAINT FK_AnimadorAnimatic2DAnimatic2D FOREIGN KEY(idAnimatic2D) REFERENCES Animatic2D(idAnimatic2D);
--AnimadorModelo
ALTER TABLE AnimadorModelo ADD CONSTRAINT FK_AnimadorModeloAnimador FOREIGN KEY(idAnimador) REFERENCES Animador(idAnimador);
ALTER TABLE AnimadorModelo ADD CONSTRAINT FK_AnimadorModeloModelado FOREIGN KEY(idModelado) REFERENCES Modelado(idModelado);
--ArtistaAreaConceptual
ALTER TABLE ArtistaAreaConceptual ADD CONSTRAINT FK_ArtistaAreaConceptualArtista FOREIGN KEY(idArtista) REFERENCES Artista(idArtista);
ALTER TABLE ArtistaAreaConceptual ADD CONSTRAINT FK_ArtistaAreaConceptualArteConceptual FOREIGN KEY(idArteConceptual) REFERENCES ArteConceptual(idArteConceptual);
--ArtistaStoryBoard
ALTER TABLE ArtistaStoryBoard ADD CONSTRAINT FK_ArtistaStoryBoardArtista FOREIGN KEY(idArtista) REFERENCES Artista(idArtista);
ALTER TABLE ArtistaStoryBoard ADD CONSTRAINT FK_ArtistaStoryBoardStoryBoard FOREIGN KEY(idStoryBoard) REFERENCES StoryBoard(idStoryBoard);
--CambioDirectivo
ALTER TABLE CambioDirectivo ADD CONSTRAINT FK_CambioDirectivoCambio FOREIGN KEY(idCambio) REFERENCES Cambio(idCambio);
ALTER TABLE CambioDirectivo ADD CONSTRAINT FK_CambioDirectivoDirectivo FOREIGN KEY(idDirectivo) REFERENCES Directivo(idDirectivo);
--DirectorGerente
ALTER TABLE DirectorGerente ADD CONSTRAINT FK_DirectorGerenteDirector FOREIGN KEY(idDirector) REFERENCES Director(idDirector);
ALTER TABLE DirectorGerente ADD CONSTRAINT FK_DirectorGerenteGerente FOREIGN KEY(idGerente) REFERENCES Gerente(idGerente);
--IngresoExhibicionInternacional
ALTER TABLE IngresoExhibicionInternacional ADD CONSTRAINT FK_IngresoExhibicionInternacionalIngreso FOREIGN KEY(idIngreso) REFERENCES Ingreso(idIngreso);
ALTER TABLE IngresoExhibicionInternacional ADD CONSTRAINT FK_IngresoExhibicionInternacionalExhibicionInternacional FOREIGN KEY(idExhibicionInternacional) REFERENCES ExhibicionInternacional(idExhibicionInternacional);
--IngresoExhibicionNacional
ALTER TABLE IngresoExhibicionNacional ADD CONSTRAINT FK_IngresoExhibicionNacionalIngreso FOREIGN KEY(idIngreso) REFERENCES Ingreso(idIngreso);
ALTER TABLE IngresoExhibicionNacional ADD CONSTRAINT FK_IngresoExhibicionNacionalExhibicionNacional FOREIGN KEY(idExhibicionNacional) REFERENCES ExhibicionNacional(idExhibicionNacional);
--LayoutTecnico
ALTER TABLE LayoutTecnico ADD CONSTRAINT FK_LayoutTecnicoLayout FOREIGN KEY(idLayout) REFERENCES Layout(idLayout);
ALTER TABLE LayoutTecnico ADD CONSTRAINT FK_LayoutTecnicoTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--MusicaMusico
ALTER TABLE MusicaMusico ADD CONSTRAINT FK_MusicaMusicoMusica FOREIGN KEY(idMusica) REFERENCES Musica(idMusica);
ALTER TABLE MusicaMusico ADD CONSTRAINT FK_MusicaMusicoMusico FOREIGN KEY(idMusico) REFERENCES Musico(idMusico);
--PostProduccionTecnico
ALTER TABLE PostProduccionTecnico ADD CONSTRAINT FK_PostProduccionTecnicoPostProduccion FOREIGN KEY(idPostProduccion) REFERENCES PostProduccion(idPostProduccion);
ALTER TABLE PostProduccionTecnico ADD CONSTRAINT FK_PostProduccionTecnicoTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
--VFXTecnico
ALTER TABLE VFXTecnico ADD CONSTRAINT FK_VFXTecnicoTecnico FOREIGN KEY(idTecnico) REFERENCES Tecnico(idTecnico);
ALTER TABLE VFXTecnico ADD CONSTRAINT FK_VFXTecnicoVFX FOREIGN KEY(idVFX) REFERENCES VFX(idVFX);

--INDICES
CREATE INDEX TX_Animatic2D ON Animatic2D(idAnimatic2D);
CREATE INDEX TX_ArteConceptual ON ArteConceptual(idArteConceptual);
CREATE INDEX TX_Cambio ON Cambio(idCambio);
CREATE INDEX TX_Director ON Director(idDirector);
CREATE INDEX TX_Ingreso ON Ingreso(idIngreso);
CREATE INDEX TX_JuntaDirectiva ON JuntaDirectiva(idJuntaDirectiva);
CREATE INDEX TX_Layout ON Layout(idLayout);
CREATE INDEX TX_Musico ON Musico(idMusico);
CREATE INDEX TX_PostProduccion ON PostProduccion(idPostProduccion);
CREATE INDEX TX_StoryBoard ON StoryBoard(idStoryBoard);
CREATE INDEX TX_VFX ON VFX(idVFX);
CREATE INDEX TX_Actor ON Actor(idActor);
CREATE INDEX TX_AsistenteAnimacion ON AsistenteAnimacion(idAsistenteAnimacion);
CREATE INDEX TX_Animacion ON Animacion (idAnimacion);
CREATE INDEX TX_Animador ON Animador(idAnimador);
CREATE INDEX TX_Artista ON Artista(idArtista);
CREATE INDEX TX_Colaboracion ON Colaboracion(idColaboracion);
CREATE INDEX TX_ColorScript ON ColorScript(idColorScript);
CREATE INDEX TX_Tecnico ON Tecnico(idTecnico);
CREATE INDEX TX_Compositing ON Compositing(idCompositing);
CREATE INDEX TX_CorreccionColor ON CorreccionColor(idCorreccionColor);
CREATE INDEX TX_DiaPresentacion ON DiaPresentacion(idDiaPresentacion);
CREATE INDEX TX_Directivo ON Directivo(idDirectivo);
CREATE INDEX TX_Esqueletizacion ON Esqueletizacion(idEsqueletizacion);
CREATE INDEX TX_Gerente ON Gerente(idGerente);
CREATE INDEX TX_ExhibicionInternacional ON ExhibicionInternacional(idExhibicionInternacional);
CREATE INDEX TX_ExhibicionNacional ON ExhibicionNacional(idExhibicionNacional);
CREATE INDEX TX_Fondista ON Fondista(idFondista);
CREATE INDEX TX_FxPersonaje ON FxPersonaje(idFxPersonaje);
CREATE INDEX TX_GrabacionVoz ON GrabacionVoz(idGrabacionVoz);
CREATE INDEX TX_Guionista ON Guionista(idGuionista);
CREATE INDEX TX_Guion ON Guion(idGuion);
CREATE INDEX TX_Idea ON Idea(idIdea);
CREATE INDEX TX_Iluminacion ON Iluminacion(idIluminacion);
CREATE INDEX TX_Masterizacion ON Masterizacion(idMasterizacion);
CREATE INDEX TX_MattePainting ON MattePainting(idMattePainting);
CREATE INDEX TX_Modelado ON Modelado(idModelado);
CREATE INDEX TX_Musica ON Musica(idMusica);
CREATE INDEX TX_Patrocinador ON Patrocinador(idPatrocinador);
CREATE INDEX TX_Pelicula ON Pelicula(idPelicula);
CREATE INDEX TX_PreExhibicion ON PreExhibicion(idPreExhibicion);
CREATE INDEX TX_Presupuesto ON Presupuesto(idPresupuesto);
CREATE INDEX TX_Productor ON Productor(idProductor);
CREATE INDEX TX_Publicidad ON Publicidad(idPublicidad);
CREATE INDEX TX_PulidoCamara ON PulidoCamara(idPulidoCamara);
CREATE INDEX TX_Rediseño ON Rediseño(idRediseño);
CREATE INDEX TX_Revision ON Revision(idRevision);
CREATE INDEX TX_SetDressing ON SetDressing(idSetDressing);
CREATE INDEX TX_SFX ON SFX(idSFX);
CREATE INDEX TX_Texturizado ON Texturizado(idTexturizado);
CREATE INDEX TX_ActorGrabacionVoz ON ActorGrabacionVoz(idActorGrabacionVoz);
CREATE INDEX TX_AnimacionAnimador ON AnimacionAnimador(idAnimacionAnimador);
CREATE INDEX TX_AnimadorAnimatic2D ON AnimadorAnimatic2D(idAnimadorAnimatic2D);
CREATE INDEX TX_AnimadorModelo ON AnimadorModelo(idAnimadorModelo);
CREATE INDEX TX_ArtistaArteConceptual ON ArtistaAreaConceptual(idArtistaAreaConceptual);
CREATE INDEX TX_ArtistaStoryBoard ON ArtistaStoryBoard(idArtistaStoryBoard);
CREATE INDEX TX_CambioDirectivo ON CambioDirectivo(idCambioDirectivo);
CREATE INDEX TX_DirectorGerente ON DirectorGerente(idDirectorGerente);
CREATE INDEX TX_IngresoExhibicionInternacional ON IngresoExhibicionInternacional(idIngresoExhibicionInternacional);
CREATE INDEX TX_IngrecioExhibicionNacional ON IngresoExhibicionNacional(idIngresoExhibicionNacional);
CREATE INDEX TX_LayoutTecnico ON LayoutTecnico(idLayoutTecnico);
CREATE INDEX TX_MusicaMusico ON MusicaMusico(idMusicaMusico);
CREATE INDEX TX_PostProduccionTecnico ON PostProduccionTecnico(idPostProduccionTecnico);
CREATE INDEX TX_VFXTecnico ON VFXTecnico(idVFXTecnico);
