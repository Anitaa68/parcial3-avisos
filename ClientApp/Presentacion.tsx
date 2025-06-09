import { useEffect, useState } from "react";

type Equipo = {
   "Id": string,
    "Escuela": string,
    "Carrera":string,
    "Grupo": string,
    "DatosSemestre":string,
    "Proyecto": string,
    "Integrante1": string,
    "Integrante2": string,
    "Fecha": string
}



const Presentacion = () => {
    const [equipo, setEquipo] = useState<Equipo>();

    // manejo de datos
    const cargarDatos = async() => {
        const resp = await fetch("/mi-proyecto/presentacion");
        if(resp.ok) {
            const datos = await resp.json();
            console.log(datos);
            setEquipo(datos);
        }
    }

    useEffect(()=>{
        cargarDatos();
    }, []);

    // vista
    return (
        <>
           <div className="display-4">Cbtis No.105</div>
           <div className="h1">Integrantes</div>
           <div className="h2">Ana Victoria Silva González</div>
           <div className="h2">Eduardo Valdez Ochoa</div>
           <div className="h1">Pagina del Cbtis</div>
        </>
    )
}

export default Presentacion;